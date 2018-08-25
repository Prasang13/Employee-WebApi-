using Microsoft.AspNet.Identity.EntityFramework;

namespace EmployeeBackend.Models
{
    public class ApplicationUser : IdentityUser
    {

    }
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("EmployeeBackendContext", throwIfV1Schema: false )
        {

        }
    }
}
