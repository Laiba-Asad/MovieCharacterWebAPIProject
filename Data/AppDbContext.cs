using Microsoft.EntityFrameworkCore;
using MovieCharacterWebAPIProject.Models;

namespace MovieCharacterWebAPIProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Faction> Faction { get; set; }

    }
}
