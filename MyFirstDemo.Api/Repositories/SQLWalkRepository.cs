using Microsoft.EntityFrameworkCore;
using MyFirstDemo.Api.Data;
using MyFirstDemo.Api.Models.Domain;

namespace MyFirstDemo.Api.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly NZWalksDbContext dbContext;
        public SQLWalkRepository(NZWalksDbContext dbContext) { 
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreatAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public async Task<Walk?> DeleteASync(Guid id)
        {
            var existingWalk=await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if(existingWalk == null) {
                return null;
            }
            dbContext.Walks.Remove(existingWalk);
            await dbContext.SaveChangesAsync();
            return existingWalk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
           return await dbContext.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
            return await dbContext.Walks
                .Include("Difficulty").Include("Region")
                .FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk=await dbContext.Walks.FirstOrDefaultAsync(x=>x.Id == id);
            if(existingWalk == null) {
                return null;
            }
            existingWalk.Name = walk.Name;
            existingWalk.Description = walk.Description;
            existingWalk.LengthInKm = walk.LengthInKm;
            existingWalk.WalkImageUrl = walk.WalkImageUrl;
            existingWalk.RegionId = walk.RegionId;

            await dbContext.SaveChangesAsync();
            return existingWalk;
        }
    }
}
