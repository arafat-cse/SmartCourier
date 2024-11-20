namespace SmartCourier.Models
{
    public class Bank
    {
        public int BankId { get; set; }
        public int CompanyID { get; set; }
        public string? Address { get; set; }
        public string? AccountNo { get; set; }
        public string? BranchName { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
