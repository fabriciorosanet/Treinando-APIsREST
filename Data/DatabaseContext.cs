using Microsoft.EntityFrameworkCore;
using Valorant_APIsREST.Models;

namespace Treinando_APIsREST.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> opts)
            : base(opts) 
        {
            
        }

        public DbSet<Agente> Agentes { get; set; }

    }
}
