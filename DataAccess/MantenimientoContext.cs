using Microsoft.EntityFrameworkCore;
using SolExamen2.DataAccess.DBEntities;

namespace SolExamen2.DataAccess
{
    public class MantenimientoContext : DbContext
    {
        public DbSet<AlumnoEntity> Alumnos { get; set; }
        public DbSet<NotaEntity> Notas { get; set; }
        public MantenimientoContext(DbContextOptions<MantenimientoContext> option) : base(option)
        {
        }
    }
}
