using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCourier.Models
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int companyId { get; set; }
        public string? companyName { get; set; }
        public string? createBy { get; set; }
        public string? createDate { get; set; }

    }
}
