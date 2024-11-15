using System;

namespace AstrolojiApp.Models;

public class HomePageModel
{
    public AppSetting? AppSetting { get; set; }
    public IEnumerable<AstrologComment>? AstrologComments { get; set; }
    public IEnumerable<DailyNew>? DailyNews { get; set; }
    public IEnumerable<HoroscopeGroup>? HoroscopeGroups { get; set; }
    public IEnumerable<Horoscope>? Horoscopes { get; set; }
    public IEnumerable<Service>? Services { get; set; }
    public IEnumerable<SocialMedia>? SocialMedia { get; set; }
    public IEnumerable<Contact>? Contact { get; set; }

}
