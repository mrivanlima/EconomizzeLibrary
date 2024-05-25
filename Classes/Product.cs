namespace EconomizzeLibrary
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductNameAscii { get; set; } = string.Empty;
        public string ProductConcentration { get; set; } = string.Empty;
        public short ProductQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
