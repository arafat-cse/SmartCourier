using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }
        public DateTime PaymentTime { get; set; }
        public decimal Amount { get; set; }
        public string Particular { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public int PaymentModeID { get; set; }
        [ForeignKey("Parcel")]
        public int ParcelsID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public string? UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
