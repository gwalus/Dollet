using System.ComponentModel.DataAnnotations.Schema;

namespace Dollet.Core.Entities
{
    [Table("Accounts")]
    public class Account : BaseEntity
    {
        public required decimal Ammount { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public required string Icon { get; set; }
        public required string Color { get; set; }
        public required string Currency { get; set; }
        public bool IsHidden { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
    }
}
