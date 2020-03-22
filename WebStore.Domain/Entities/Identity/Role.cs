using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities.Identity
{
    public class Role : IdentityRole<string>
    {
        public const string Administrator = "Administrators";
    }
}