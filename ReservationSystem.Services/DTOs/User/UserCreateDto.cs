﻿using Microsoft.Identity.Client;

namespace ReservationSystem.Services.DTOs.User
{
    public class UserCreateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}