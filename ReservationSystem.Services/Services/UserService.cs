using ReservationSystem.Models;
using ReservationSystem.Repository.Helpers.User;
using ReservationSystem.Repository.Interfaces;
using ReservationSystem.Services.DTOs.User;
using ReservationSystem.Services.Helpers;
using ReservationSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<int> CreateUserAsync(UserCreateDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) ||
                string.IsNullOrWhiteSpace(dto.Email) ||
                string.IsNullOrWhiteSpace(dto.Username) ||
                string.IsNullOrWhiteSpace(dto.Password))
            {
                throw new ValidationException("All fields are required.");
            }

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Username = dto.Username,
                HashedPassword = SecurityHelper.HashPassword(dto.Password)
            };

            return await _userRepo.CreateAsync(user);
        }
        public async Task<UserResponse> GetByIdAsync(int userId)
        {
            var user = await _userRepo.RetrieveByIdAsync(userId);
            return MapToDto(user);
        }

        public async Task<bool> UpdatePasswordAsync(int userId, string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
            {
                throw new ValidationException("Password cannot be empty");
            }

            var hashedPassword = SecurityHelper.HashPassword(newPassword);
            var update = new UserUpdate { Password = new SqlString(hashedPassword) };
            return await _userRepo.UpdateByIdAsync(userId, update);
        }

        public async Task<bool> UpdateEmailAsync(int userId, string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail))
            {
                throw new ValidationException("Email cannot be empty");
            }

            var update = new UserUpdate { Email = new SqlString(newEmail) };
            return await _userRepo.UpdateByIdAsync(userId, update);
        }

        public async Task<bool> UpdateNameAsync(int userId, string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ValidationException("Email cannot be empty");
            }

            var update = new UserUpdate { Name = new SqlString(newName) };
            return await _userRepo.UpdateByIdAsync(userId, update);
        }

        private static UserResponse MapToDto(Models.User user)
        {
            return new UserResponse
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Name = user.Name
            };
        }
    }
}
