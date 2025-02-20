using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class HoroscopeRepository : GenericRepository<Horoscope>, IHoroscopeRepository
{
    public HoroscopeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
