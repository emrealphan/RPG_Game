using Microsoft.EntityFrameworkCore;
using RPG_Game.Models;

namespace RPG_Game.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {
            
        }

        public DbSet <Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
