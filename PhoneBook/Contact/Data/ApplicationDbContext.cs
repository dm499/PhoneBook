using Contact.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
        }

        public DbSet<PhoneContact> Phones { get; set; }
    }
}
