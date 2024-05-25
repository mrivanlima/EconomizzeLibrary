namespace EconomizzeLibrary
{
    public class UserLogin
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        public bool IsVerified { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public bool IsLocked { get; set; } = false;
        public short PasswordAttempts { get; set; } = 0;
        public bool ChangedInitialPassword { get; set; } = false;
        public DateTime? LockedTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}