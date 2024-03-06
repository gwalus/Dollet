using System.ComponentModel.DataAnnotations;

namespace Dollet.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
