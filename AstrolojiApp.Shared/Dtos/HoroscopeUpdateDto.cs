using System;

namespace AstrolojiApp.Shared.Dtos;

public class HoroscopeUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Image { get; set; }
    public string? DateRange { get; set; }
    
}
