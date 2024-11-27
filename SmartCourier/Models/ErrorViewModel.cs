namespace SmartCourier.Models
{
    public class ErrorViewModel
    {
        public string? equestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
