using System;
namespace Umbrella.WepApi.Auth.Models.Entities
{
    public class Customer 
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
    }
}
