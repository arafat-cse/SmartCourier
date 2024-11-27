using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class BranchStaff
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int branchStaffId {  get; set; }
        public string? branchStaffName { get; set; }
        [ForeignKey("Staff")]
        public int staffId {  get; set; }
    }
}
