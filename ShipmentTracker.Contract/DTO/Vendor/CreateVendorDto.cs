namespace ShipmentTracker.Core.Contract.DTO.Vendor
{
    public sealed record CreateVendorDto
    {
        public string VendorFirstName { get; set; } = "";
        public string VendorLastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
   
}
