using Microsoft.EntityFrameworkCore;
using Tareas_API.Models;

namespace Tareas_API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //con base llamamos al constructor de la clase base pasado el parametro options
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
