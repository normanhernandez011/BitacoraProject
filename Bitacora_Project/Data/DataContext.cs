using Bitacora_Project.api.model;
using Microsoft.EntityFrameworkCore;

namespace Bitacora_Project.api.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Category> Categories {get; set;}

        public DbSet<Actividades> Actividades {get; set;}

        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {
            
        }

    }
}