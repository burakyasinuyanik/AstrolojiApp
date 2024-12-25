using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
{
    public SocialMediaRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
