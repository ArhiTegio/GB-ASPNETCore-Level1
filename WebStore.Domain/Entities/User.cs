using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace WebStore.DomainNew.Entities
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        
        public string Email { get; set; }
    }
}