namespace EconomizzeLibrary
{
    public class ContactType
    {
        public short ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }
        public string ContactTypeNameAscii { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}