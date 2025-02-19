using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Data.DataServices;
using Api.Data.Configuration;

namespace Api.Data.SettingsDb
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
