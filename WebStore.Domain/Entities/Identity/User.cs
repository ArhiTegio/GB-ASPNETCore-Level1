using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities.Identity
{
    public class User : IdentityUser<string>
    {

        public const string Administrator = "Admin";
        public const string DefaultPassword = "AdminPassword";
    }
}