using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularJSAuthentication.API
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("DefaultConnection")
        {

        }
       
    }
}