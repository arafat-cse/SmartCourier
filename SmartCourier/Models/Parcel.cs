using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Parcel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int parcelId { get; set; }
        public string? parcelCode { get; set; }
        [ForeignKey("Customer")]
        public int senderCustomerId { get; set; }
        [ForeignKey("Customer")]
        public int receiverCustomerId { get; set; }
        public DateTime sendTime { get; set; }
        public DateTime receiveTime { get; set; }
        [ForeignKey("Branch")]
        public int senderBranchId { get; set; }
        [ForeignKey("Branch")]
        public int receiverBranchId { get; set; }
        public DateTime estimatedReceiveTime { get; set; }
        public bool isPaid { get; set; }
        [ForeignKey("Van")]
        public int? vanID { get; set; }
        [ForeignKey("Driver")]
        public int? driverId { get; set; }
        [ForeignKey("")]
        public int? deliveryChargeId { get; set; }
        [ForeignKey("Parcel")]
        public int? parcelTypeId { get; set; }
        public decimal price { get; set; }
        public decimal weight { get; set; }
        public string? createBy { get; set; }
        public DateTime createDate { get; set; }
        public string? updateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool sendingBranch { get; set; }
        public bool percelSendingDestribution { get; set; }
        public bool recebingDistributin { get; set; }
        public bool recebingBranch { get; set; }
        public bool recebingReceber { get; set; }
        public bool IsActive { get; set; }

    }
}
 