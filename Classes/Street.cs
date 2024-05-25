namespace EconomizzeLibrary
{
    public class Street
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; } = string.Empty;
        public string StreetNameAscii { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int NeighborhoodId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}