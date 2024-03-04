namespace Dollet.Core.Entities
{
    public class Currency : BaseEntity
    {
        public required string Name { get; set; }
        public bool IsDefault { get; set; }
    }
}
