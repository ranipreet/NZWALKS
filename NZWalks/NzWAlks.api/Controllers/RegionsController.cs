using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NzWAlks.api.Models.Domains;
using NzWAlks.api.Repositories;

namespace NzWAlks.api.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAll();

            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            //var regionsDTO= new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region=>
            //    {
            //        var regionDto= new Models.DTO.Region()
            //        {
            //            Id= region.Id,
            //            Name=region.Name,
            //            Area=region.Area,
            //            Lat=region.Lat,
            //            Code=region.Code,
            //            Long=region.Long,
            //            Population=region.Population,
            //            Walks=region.Walks,
            //        };
            //        regionsDTO.Add(regionDto);
            //});
            return Ok(regionsDTO);
        }
    }
}
