﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCourier.Models
{
    public class Branch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int branchId { get; set; }
        public string? branchName { get; set; }
        public string? address { get; set; }
        public string? createBy { get; set; }
        public DateTime? createDate { get; set; }
        public string? updateBy { get; set; }
        public DateTime? updateDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Parcel>? Parcels { get; set; }

    }
}
