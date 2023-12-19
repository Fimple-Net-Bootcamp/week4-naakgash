﻿using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IRepositories;

public interface IUserRepository
{
    Task<User> CreateAsync(User user);
    Task<User> GetByIdAsync(int id);
}
