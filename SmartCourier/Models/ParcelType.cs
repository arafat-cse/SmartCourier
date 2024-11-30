namespace SmartCourier.Models
{
    public class ParcelType
    {
        public int parcelTypeId { get; set; }
        public string? parcelTypeName { get; set; }
        public string? createBy { get; set; }
        public DateTime? createDate { get; set; }
        public string? updateBy { get; set; }
        public DateTime? updateDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Parcel>? Parcels { get; set; }

    }
}
