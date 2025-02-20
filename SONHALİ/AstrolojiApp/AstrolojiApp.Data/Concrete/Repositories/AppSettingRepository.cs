using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class AppSettingRepository : GenericRepository<AppSetting>, IAppSettingRepository
{
    public AppSettingRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
