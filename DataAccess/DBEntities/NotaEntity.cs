using SolExamen2.DataAccess.DBEntities.Abstraccions;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolExamen2.DataAccess.DBEntities
{
    [Table("Notas")]
    public class NotaEntity : EntityBase
    {
        public string NombreCurso { get; set; }
        public double Nota { get; set; }
        public virtual AlumnoEntity alumnos { get; set; }
    }
}
