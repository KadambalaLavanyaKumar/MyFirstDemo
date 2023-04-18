﻿using MyFirstDemo.Api.Models.Domain;

namespace MyFirstDemo.Api.Repositories
{
    public interface IRegionRepository
    {
       Task<List<Region>> GetAllAsync();
        Task<Region?> GetByIdAsync(Guid id);
        Task<Region> CreateAsync(Region region);
        Task<Region?> UpdateAsync(Guid id,Region region);
        Task<Region?> DeleteAsync(Guid id);

    }
}