﻿using Office_supplies_management.Models;

namespace Office_supplies_management.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<string> GetNameById (int id);
    }
}
