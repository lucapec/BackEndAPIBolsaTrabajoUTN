﻿using ApiBolsaTrabajoUTN.API.Entities;
using ApiBolsaTrabajoUTN.API.Helpers;
using ApiBolsaTrabajoUTN.API.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiBolsaTrabajoUTN.API.Services.Authentication
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly UserManager<Admin> _adminManager;
        private readonly UserManager<Company> _companyManager;
        private readonly UserManager<Student> _studentManager;
        private readonly IJwtService _jwtService;
        public AuthenticationRepository(UserManager<User> userManager, UserManager<Admin> adminManager, UserManager<Company> companyManager, UserManager<Student> studentManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _adminManager = adminManager;
            _companyManager = companyManager;
            _studentManager = studentManager;
            _jwtService = jwtService;
        }
        public async Task<AuthenticationModelResponse> Authenticate(AuthenticationModelRequest rq)
        {
            var response = new AuthenticationModelResponse();

            // Not empty request validation
            if (rq.Email == null || rq.Password == null)
            {
                response.Success = false;
                response.Message = "Please, introduce valid data.";
                return response;
            }

            // Finds user through email
            var user = await _userManager.FindByEmailAsync(rq.Email);

            // Validation that the user exists and passwords are the same
            if (user is null || !await _userManager.CheckPasswordAsync(user, rq.Password))
            {
                response.Success = false;
                response.Message = "The user was not found";
                return response;
            }

            // Token generation
            var tokenToReturn = await _jwtService.Generate(user);

            response.Success = true;
            response.Message = "You have been correctly logged in";
            response.Token = tokenToReturn;
            return response;
        }
    }
}
