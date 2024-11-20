using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Parcel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParcelId { get; set; }
        public string ParcelCode { get; set; }
        [ForeignKey("Customer")]
        public int SenderCustomerID { get; set; }
        [ForeignKey("Customer")]
        public int ReceiverCustomerID { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime ReceiveTime { get; set; }
        [ForeignKey("Branch")]
        public int SenderBranchID { get; set; }
        [ForeignKey("Branch")]
        public int ReceiverBranchID { get; set; }
        public DateTime EstimatedReceiveTime { get; set; }
        public bool IsPaid { get; set; }
        [ForeignKey("Van")]
        public int? VanID { get; set; }
        [ForeignKey("Driver")]
        public int? DriverID { get; set; }
        [ForeignKey("")]
        public int? DeliveryChargeID { get; set; }
        [ForeignKey("Parcel")]
        public int? ParcelTypeID { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
