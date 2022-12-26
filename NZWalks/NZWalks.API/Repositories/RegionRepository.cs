using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDBContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext) 
        {
            this.nZWalksDBContext = nZWalksDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
           return await nZWalksDBContext.Regions.ToListAsync();
        }
    }
}
