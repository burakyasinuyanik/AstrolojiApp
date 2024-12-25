using System;
using AstrolojiApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AstrolojiApp.Data.Concrete.Context;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Horoscope> Horoscopes { get; set; }
    public DbSet<AppSetting> AppSettings { get; set; }
    public DbSet<AstrologComment> AstrologComments  { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DailyNew> DailyNews { get; set; }
    public DbSet<HoroscopeComment> HoroscopeComments { get; set; }
    public DbSet<HoroscopeGroup> HoroscopeGroups { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }

}
