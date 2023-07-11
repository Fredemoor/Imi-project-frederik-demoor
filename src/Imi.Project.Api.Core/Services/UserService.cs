using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces;
using Imi.Project.Api.Core.Interfaces.IServices;
using Imi.Project.Api.Core.Services.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        //JwtService class here
        private readonly IJwtService _jwtService;
        private readonly IConfiguration _configuration;
        public UserService(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            IJwtService jwtService)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _jwtService = jwtService;
        }
        public IQueryable<ApplicationUser> GetUsers()
        {
            return _userManager.Users;
        }

        public async Task<AuthenticateResultModel> Login(string email, string password)
        {
            var getUserName = await _userManager.FindByEmailAsync(email);
            string userName = getUserName.UserName;
            var login = await _signInManager.PasswordSignInAsync(userName, password, true, false);

            if (!login.Succeeded)
            {
                return new AuthenticateResultModel
                {
                    Messages = new List<string> { "Login failed!" }
                };
            }

            var user = await _userManager.FindByNameAsync(userName);
            //user exists => generate token
            //get the claims
            var claims = (List<Claim>)await _userManager.GetClaimsAsync(user);
            //generate the token
            var token = _jwtService.GenerateToken(claims);
            //serialize the token
            var serializedToken = _jwtService.SerializeToken(token);
            //return the token
            return new AuthenticateResultModel { Success = true, Messages = new List<string> { serializedToken } };
        }

        public async Task<AuthenticateResultModel> Register(string username, string email, string password, DateTime birthdate, bool termsAndConditions)
        {
            //create a user
            var applicationUser = new ApplicationUser
            {
                UserName = username,
                NormalizedUserName = username,
                NormalizedEmail = email,
                Email = email,
                PasswordHash = password,
                Birthdate = birthdate,
                HasApprovedTermsAndConditions = termsAndConditions
            };

            //store in database
            var result = await _userManager.CreateAsync(applicationUser, password);
            if (!result.Succeeded)
            {
                return new AuthenticateResultModel
                {
                    Messages = new List<string> { "Registration failed!" }
                };
            }
            //get the user and add a claim registration-date
            applicationUser = await _userManager.FindByNameAsync(username);
            //add a claim registration-date
            await _userManager
                .AddClaimAsync(applicationUser, new Claim("registration-date", DateTime.UtcNow.ToString("yy-MM-dd")));

            return new AuthenticateResultModel
            {
                Success = true,
                Messages = new List<string> { "user registered!" }
            };
        }
    }
}

