using Microsoft.AspNetCore.Identity;

namespace Salon.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
