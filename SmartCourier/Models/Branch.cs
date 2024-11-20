﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCourier.Models
{
    public class Branch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? Address { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
