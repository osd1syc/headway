﻿using Headway.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Headway.Core.Interface
{
    public interface IAuthorisationService : IService
    {
        Task<IServiceResult<IEnumerable<User>>> GetUsersAsync();
        Task<IServiceResult<User>> GetUserAsync(int userId);
        Task<IServiceResult<User>> AddUserAsync(User user);
        Task<IServiceResult<User>> UpdateUserAsync(User user);
        Task<IServiceResult<int>> DeleteUserAsync(int userId);
        Task<IServiceResult<IEnumerable<Permission>>> GetPermissionsAsync();
        Task<IServiceResult<Permission>> GetPermissionAsync(int permissionId);
        Task<IServiceResult<Permission>> AddPermissionAsync(Permission permission);
        Task<IServiceResult<Permission>> UpdatePermissionAsync(Permission permission);
        Task<IServiceResult<int>> DeletePermissionAsync(int permissionId);
        Task<IServiceResult<IEnumerable<Role>>> GetRolesAsync();
        Task<IServiceResult<Role>> GetRoleAsync(int roleId);
        Task<IServiceResult<Role>> AddRoleAsync(Role role);
        Task<IServiceResult<Role>> UpdateRoleAsync(Role role);
        Task<IServiceResult<int>> DeleteRoleAsync(int roleId);
    }
}