using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class HoroscopeCommentRepository : GenericRepository<HoroscopeComment>, IHoroscopeCommentRepository
{
    public HoroscopeCommentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
