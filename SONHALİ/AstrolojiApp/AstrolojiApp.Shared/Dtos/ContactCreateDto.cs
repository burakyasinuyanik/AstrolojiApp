using System;

namespace AstrolojiApp.Shared.Dtos;

public class ContactCreateDto
{
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Icon { get; set; }
    public string? Map { get; set; }
}
