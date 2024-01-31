using Agro.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agro.web.Data
{
    public class DataContext:DbContext
    {
        public DbSet<City> Cities { get; set; } //Clases objetos a tablas.
        public DbSet<ProductType> ProductTypes { get; set; } //Mapeo, mi objeto producto type se está mapeando con la tabla product types
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Indicamos que el campo nombre va a ser único. 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasIndex(x => x.Name).IsUnique();
        }
    } //Usamos entitiy framework para crear nuestra base de datos. 
}
