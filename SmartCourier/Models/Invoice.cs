using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int invoiceId { get; set; }
        public DateTime paymentTime { get; set; }
        public decimal amount { get; set; }
        public string? particular { get; set; }
        [ForeignKey("Customer")]
        public int customerId { get; set; }
        public int paymentModeId { get; set; }
        [ForeignKey("Parcel")]
        public int ParcelsId { get; set; }
        public string? createBy { get; set; }
        public DateTime createDate { get; set; }
        public string? updateBy { get; set; }
        public string? updateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
