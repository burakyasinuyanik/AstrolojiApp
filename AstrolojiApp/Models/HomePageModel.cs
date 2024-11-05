using System;

namespace AstrolojiApp.Models;

public class HomePageModel
{
    public AppSetting? AppSetting { get; set; }
    public IEnumerable<AstrologComment>? AstrologComments { get; set; }
    public IEnumerable<DailyNews>? DailyNews { get; set; }
    public IEnumerable<HoroscopeGroups>? HoroscopeGroups { get; set; }
    public IEnumerable<Horoscopes>? Horoscopes { get; set; }
    public IEnumerable<Services>? Services { get; set; }
}
