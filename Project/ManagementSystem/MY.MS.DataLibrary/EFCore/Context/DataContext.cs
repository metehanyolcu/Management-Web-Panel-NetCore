using Microsoft.EntityFrameworkCore;
using MY.MS.Entities.Concrete;

namespace MY.MS.DataLibrary.EFCore.Context
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server  = METEPC06; database = MSDemo; user id = sa; password = 1234;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasIndex(c => new { c.CategoryName }).IsUnique();

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Items> Items { get; set; }
    }
}
