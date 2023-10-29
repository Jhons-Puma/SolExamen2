using System.ComponentModel.DataAnnotations;

namespace SolExamen2.DataAccess.DBEntities.Abstraccions
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
