namespace SmartCourier.Models
{
    public class ParcelType
    {
        public int ParcelTypeID { get; set; }
        public string ParcelTypeName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
