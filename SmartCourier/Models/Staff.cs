using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Staff
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Email { get; set; }
        public string? Designation { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
