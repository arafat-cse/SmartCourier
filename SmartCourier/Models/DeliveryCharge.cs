﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class DeliveryCharge
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int deliveryChargeId { get; set; }
        [ForeignKey("ParcelType")]
        public int parcelTypeId { get; set; }
        public virtual ParcelType? ParcelTypes { get; set; }
        public double weight { get; set; }
        public decimal price { get; set; }
        public string? createBy { get; set; }
        public DateTime createDate { get; set; }
        public string? updateBy { get; set; }
        public DateTime? updateDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Parcel>? Parcels { get; set; }

    }
}
