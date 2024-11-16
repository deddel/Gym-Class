using Microsoft.AspNetCore.Identity;

namespace Gym_Class.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<GymClass> AttendedClasses { get; set; }
    }
}
