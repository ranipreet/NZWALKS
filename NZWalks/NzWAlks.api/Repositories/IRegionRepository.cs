using NzWAlks.api.Models.Domains;

namespace NzWAlks.api.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAll();
    }
}
