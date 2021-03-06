﻿using Microsoft.AspNetCore.Http;
using NotClean.Services.Interfaces;

namespace NotClean.Services.Implementation
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            IsAuthenticated = httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
            Id = 1;
            Email = "test@tets.com";

            //if (IsAuthenticated)
            //{
            //    UserId = int.Parse(httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            //    Email = _httpContextAccessor.HttpContext.User.Identity.Name;
            //}
        }

        public int Id { get; }
        public bool IsAuthenticated { get; }
        public string Email { get; set; }
    }
}
