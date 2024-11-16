using Gym_Class.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gym_Class.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string> //string is the Key
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GymClass> GymClass { get; set; } = default!; 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUserGymClass>()
                .HasKey(a => new { a.ApplicationUserId, a.GymClassId });
        }
    }
}
