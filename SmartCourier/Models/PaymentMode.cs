namespace SmartCourier.Models
{
    public class PaymentMode
    {
        public int PaymentModeID { get; set; }
        public string? PaymentModeName { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
