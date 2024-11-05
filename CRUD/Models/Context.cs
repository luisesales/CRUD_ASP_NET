using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        { 
            
        }

        public DbSet<Client> Clients { get; set; }
    }
}
