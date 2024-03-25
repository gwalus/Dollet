using System.ComponentModel.DataAnnotations.Schema;

namespace Dollet.Core.Entities
{
    [Table("Expenses")]
    public class Expense : BaseEntity 
    {
        public decimal Amount { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
    }
}