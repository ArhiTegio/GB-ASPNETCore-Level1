using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using IdentityUser = Microsoft.AspNetCore.Identity.IdentityUser;

namespace WebStore.Domain.Entities.Identity
{
    public class User : IdentityUser
    {

        public const string Administrator = "Admin";
        public const string DefaultPassword = "AdminPassword";
    }
}