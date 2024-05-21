﻿using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkRepository
    {
        Task<List<WalkDomain>> GetAllAsync();
        Task<WalkDomain?> GetByIdAsync(Guid id);
        Task<WalkDomain> CreateAsync(WalkDomain walkDomain);
    }
}
