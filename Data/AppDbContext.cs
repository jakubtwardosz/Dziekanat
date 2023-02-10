using Microsoft.EntityFrameworkCore;

namespace Dziekanat.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Models.Instructor> Instructors { get; set; } = default!;

        /* do uzupełnienia */
    }
}
