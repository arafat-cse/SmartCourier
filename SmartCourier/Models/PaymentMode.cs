namespace SmartCourier.Models
{
    public class PaymentMode
    {
        public int paymentModeId { get; set; }
        public string? paymentModeName { get; set; }
        public string? createBy { get; set; }
        public DateTime? createDate { get; set; }
        public string? updateBy { get; set; }
        public DateTime? updateDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
