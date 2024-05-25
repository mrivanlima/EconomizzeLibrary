namespace EconomizzeLibrary
{
    public class AddressType
    {
        public short AddressTypeId { get; set; }
        public string AddressTypeName { get; set; } = string.Empty;
        public string AddressTypeNameAscii { get; set; } = string.Empty;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
