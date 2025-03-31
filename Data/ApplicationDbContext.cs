using Microsoft.EntityFrameworkCore;
using SpoonNScroll.Models;

namespace SpoonNScroll.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

            public DbSet<User> Users { get; set; }



    }
}
