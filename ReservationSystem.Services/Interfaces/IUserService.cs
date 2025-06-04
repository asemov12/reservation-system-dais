using ReservationSystem.Services.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Services.Interfaces
{
    public interface IUserService
    {
        Task<int> CreateUserAsync(UserCreateDto dto);
        Task<UserResponse> GetByIdAsync(int userId);
        Task<bool> UpdatePasswordAsync(int userId, string newPassword);
        Task<bool> UpdateEmailAsync(int userId, string newEmail);
        Task<bool> UpdateNameAsync(int userId, string newName);
    }
}
