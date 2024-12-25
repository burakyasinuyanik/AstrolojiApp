using System;

namespace AstrolojiApp.Entity.Concrete;

public class AppSetting
{
    public int Id { get; set; }
    public string? WorkingHours { get; set; }
    public string? BrandName { get; set; }
    public string? ImageUrl { get; set; }
    public string? Title { get; set; }
    public string? AboutText { get; set; }
    public string? HoroscopeName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}
