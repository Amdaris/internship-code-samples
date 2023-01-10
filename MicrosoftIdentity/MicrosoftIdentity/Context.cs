using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MicrosoftIdentity
{
    public class Context : IdentityDbContext<User,IdentityRole<int>,int>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<MentorSkill> MentorSkills { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
