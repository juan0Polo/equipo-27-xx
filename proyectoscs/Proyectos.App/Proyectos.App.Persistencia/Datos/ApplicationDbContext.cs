using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Persistencia.Datos
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        //poner aqui los modelos
        public DbSet<Formador> formador{get; set;}
    }
}