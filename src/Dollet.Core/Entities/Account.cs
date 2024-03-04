namespace Dollet.Core.Entities
{
    public class Account : BaseEntity
    {
        public required string Name { get; set; }
        public required string Icon { get; set; }
        public required string Color { get; set; }
        public bool IsHidden { get; set; } = false;
    }
}
