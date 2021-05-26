using Microsoft.EntityFrameworkCore;
using Practica03.Models;
namespace Practica03.Data
{
    public class AplicacionDbContext
    {
        public class ApplicationDbContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions p) : base (p)
        {
            
        }
    }
    }
}