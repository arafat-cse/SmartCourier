using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCourier.Models
{
    public class Van
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int vanId { get; set; }
        public string? registrationNo { get; set; }
        public DateTime? createdDate { get; set; }
        public int updateBy { get; set; }
        public DateTime updateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
