using Microsoft.EntityFrameworkCore;
using NzWAlks.api.Data;
using NzWAlks.api.Models.Domains;

namespace NzWAlks.api.Repositories
{
    public class SqlRegionRepository : IRegionRepository
    {
        private readonly NZWalksDBContext nZWalksDBContext;

        public SqlRegionRepository(NZWalksDBContext nZWalksDBContext)
        {
            this.nZWalksDBContext = nZWalksDBContext;
        }
        public async Task< IEnumerable<Region>> GetAll()
        {
            return await nZWalksDBContext.Regions.ToListAsync();
        }
    }
}
