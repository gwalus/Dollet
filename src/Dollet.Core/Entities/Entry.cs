﻿namespace Dollet.Core.Entities
{
    public class Entry : BaseEntity
    {
        public required decimal Amount { get; set; }
        public required Currency Currency { get; set; }
        public required Account Account { get; set; }
        public required Category Category { get; set; }
        public required DateTime Date { get; set; }
        public string? Comment { get; set; }

        // Photos?
    }

}