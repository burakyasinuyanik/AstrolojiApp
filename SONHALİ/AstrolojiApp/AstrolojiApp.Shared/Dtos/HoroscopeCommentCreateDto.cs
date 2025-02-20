using System;

namespace AstrolojiApp.Shared.Dtos;

public class HoroscopeCommentCreateDto
{

    public int HoroscopeId { get; set; }
    public string? Daily { get; set; }
    public string? Monthly { get; set; }
    public string? Annual { get; set; }
    public string? Name { get; set; }
}
