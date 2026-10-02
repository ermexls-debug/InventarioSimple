using InventarioSimple.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioSimple.Data

{

    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Producto> Productos { get; set; }

    }

}
    

