using Microsoft.EntityFrameworkCore;
using SpendSmart.Models;

namespace SpendSmart.Views.Home
{
    public class SpendSmartDbContext : DbContext
    {
        // DbSet representing the Expenses table in the database
        public DbSet<Expense> Expenses { get; set; }

        // Constructor accepting DbContextOptions and passing them to the base class constructor
        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            : base(options)  // Corrected options name
        {
        }
    }
}
