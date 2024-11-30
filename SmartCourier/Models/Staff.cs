﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Staff
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int staffId { get; set; }
        public string? staffName { get; set; }
        public string? email { get; set; }
        public string? designation { get; set; }
        public string? createBy { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime updateBy { get; set; }
        public DateTime? updateDate { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<Branch>? Branchs { get; set; }


    }
}
