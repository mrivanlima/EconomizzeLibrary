namespace EconomizzeLibrary
{
    public class UserAddress
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public short AddressTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
