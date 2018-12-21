using System;
using Microsoft.AspNetCore.Identity;

namespace Umbrella.WepApi.Auth.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
