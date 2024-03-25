using System.ComponentModel.DataAnnotations.Schema;

namespace Dollet.Core.Entities
{
    [Table("Incomes")]
    public class Income : BaseEntity 
    {
        public decimal Amount { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public int AccountId { get; set; }
    }
}
