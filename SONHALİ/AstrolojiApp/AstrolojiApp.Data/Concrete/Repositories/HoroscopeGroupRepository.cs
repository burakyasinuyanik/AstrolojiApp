using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class HoroscopeGroupRepository : GenericRepository<HoroscopeGroup>, IHoroscopeGroupRepository
{
    public HoroscopeGroupRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
