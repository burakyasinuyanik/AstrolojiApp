using System;

namespace AstrolojiApp.Shared.Dtos;

public class HoroscopeGroupUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string HoroscopeNames { get; set; }
    public string? Image { get; set; }
   
}
