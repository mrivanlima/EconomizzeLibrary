namespace EconomizzeLibrary
{
    public class Quote
    {
        public long QuoteId { get; set; }
        public int UserId { get; set; }
        public int NeighborhoodId { get; set; }
        public string PrescriptionUrl { get; set; } = string.Empty;
        public bool IsExpired { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
