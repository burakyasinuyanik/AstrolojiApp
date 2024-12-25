using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class DailyNewRepository : GenericRepository<DailyNew>, IDailyNewRepository
{
    public DailyNewRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
