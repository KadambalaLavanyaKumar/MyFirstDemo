using Microsoft.AspNetCore.Mvc;
using MyFirstDemo.Api.Models.Domain;

namespace MyFirstDemo.Api.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreatAsync(Walk walk);
        Task<List<Walk>> GetAllAsync(string? filterOn=null, string? filterQuery=null, string? sortBy=null, 
            bool? isAscending=true,int pageNumber=1, int pageSize=1000);
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<Walk?> DeleteASync(Guid id);
    }
}
