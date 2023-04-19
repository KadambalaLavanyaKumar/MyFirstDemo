using MyFirstDemo.Api.Models.Domain;

namespace MyFirstDemo.Api.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreatAsync(Walk walk);
        Task<List<Walk>> GetAllAsync();
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<Walk?> DeleteASync(Guid id);
    }
}
