using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCourier.Models
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string CreateBy { get; set; }
        public string CreateDate { get; set; }

    }
}
