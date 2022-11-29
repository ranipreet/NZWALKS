using AutoMapper;
using Microsoft.Extensions.Options;

namespace NzWAlks.api.Profiles
{
    public class RegionProfile:Profile
    {
        public RegionProfile()
        {
            CreateMap<Models.Domains.Region,Models.DTO.Region>().
                ReverseMap();
                //ForMember(dest=>dest.Id,options=>options.MapFrom(src=>src.Id));
        }
    }
}
