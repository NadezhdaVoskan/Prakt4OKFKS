using System;
using System.Collections.Generic;

namespace ElectronicLibraryAPI2.Models
{
    public partial class Logging
    {
        public int IdLogging { get; set; }
        public DateTime DateForm { get; set; }
        public decimal CostIssue { get; set; }
        public int? StatusLoggingId { get; set; }
        public int? IssueProductId { get; set; }
        public int? RiderTicketId { get; set; }
        public TimeSpan TimeNotes { get; set; }
        public int? UserId { get; set; }

    }
}
