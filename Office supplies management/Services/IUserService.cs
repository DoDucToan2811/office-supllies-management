﻿using Office_supplies_management.DTOs.Permission;
using Office_supplies_management.DTOs.User;
using Office_supplies_management.Models;

namespace Office_supplies_management.Services
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(int id);
        Task<List<UserDto>> GetAll();
        Task<UserDto> Create(CreateUserDto request);
        Task<UserDto> GetByEmail (string email);
        //Task<bool> Delete(DeleteProductRequest request);
        //Task<bool> Update(UpdateProductRequest request);
        Task<UserDto> GetById(int id);
        Task<string> GetNameById(int id);
        Task<List<UserDto>> GetUsersByDepartment(string department);
        Task<List<PermissionDto>> GetAllPermissions(int userTypeID);
        Task<List<string>> GetUniqueDepartments();
        Task<UserDto> GetDepartmentLeaderAsync(string department);
        Task<List<UserDto>> GetAllUsersByTypeAsync(int userTypeID);
    }
}
