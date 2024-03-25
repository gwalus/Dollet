using System.ComponentModel.DataAnnotations.Schema;

namespace Dollet.Core.Entities
{
    [Table("Categories")]
    public class Category : BaseEntity
    {
        public required string Name { get; set; }
        public required string Icon { get; set; }
        public required string Color { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
