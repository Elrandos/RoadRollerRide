﻿
using RoadRollerRide.DTO;
using RoadRollerRide.Model.Dto;

namespace RoadRollerRide.Service
{
    public class AuthService
    {
        private readonly UserService _userService;

        public AuthService(UserService userService)
        {
            _userService = userService;
        }

        public UserDto? Login(LoginDto loginDto)
        {
            var user = _userService.GetByName(loginDto.Name);
            if (user != null)
            {
                var authorizedUser = BCrypt.Net.BCrypt.Verify(loginDto.Password, user?.PasswordHash) ? user : null;
                if (authorizedUser != null)
                {
                    return new UserDto
                    {
                        Id = authorizedUser.Id,
                        IsAdmin = authorizedUser.IsAdmin
                    };
                }
            }

            return null;
        }
    }
}
