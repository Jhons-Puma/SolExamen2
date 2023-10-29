using SolExamen2.DataAccess.DBEntities.Abstraccions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolExamen2.DataAccess.DBEntities
{
    [Table("Alumnos")]
    public class AlumnoEntity : EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Status { get; internal set; }
    }
}
