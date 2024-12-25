
using System;

namespace AstrolojiApp.Shared.Dtos;

public class ContactUpdateDto
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Icon { get; set; }
    public string? Map { get; set; }
}
