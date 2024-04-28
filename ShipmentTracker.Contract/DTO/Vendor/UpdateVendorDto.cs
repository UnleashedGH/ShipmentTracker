namespace ShipmentTracker.Core.Contract.DTO.Vendor;

public sealed record UpdateVendorDto
{
    public string VendorFirstName { get; set; } = "";
    public string VendorLastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Address { get; set; } = "";
    public DateTime UpdateDate { get; set; } = DateTime.Now;
}