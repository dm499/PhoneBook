using Contact.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Data
{
    public class ApplicaionDbContext : DbContext
    {
        public ApplicaionDbContext(DbContextOptions<ApplicaionDbContext> options)
            : base (options)
        {
        }

        public DbSet<PhoneContact> Phones { get; set; }
    }
}
