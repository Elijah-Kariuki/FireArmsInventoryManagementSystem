using Microsoft.EntityFrameworkCore;

namespace FireArmsInventoryManagementSystem.Data
{
    public class FirearmsInventoryDB : DbContext
    {
        public FirearmsInventoryDB(DbContextOptions<FirearmsInventoryDB> options) : base(options)
        {
        }

        // Define DbSet properties for your entities here
        // Example:
        // public DbSet<Firearm> Firearms { get; set; }
    }
}
