using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCourier.Models
{
    public class Van
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VanId { get; set; }
        public string RegistrationNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
