using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCourier.Models
{
    public class Bank
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bankId { get; set; }       
        [ForeignKey("Company")]
        public int companyId { get; set; }
        public string? address { get; set; }
        public string? accountNo { get; set; }     
        public string? branchName { get; set; }
        public string? createBy { get; set; }
        public DateTime? createDate { get; set; }
        public string? updateBy { get; set; }
        public DateTime? updateDate { get; set; }
        public bool IsActive { get; set; }
        public virtual Company? Companys { get; set; }
        

    }
}
