using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class ServiceRepository : GenericRepository<Service>, IServiceRepository
{
    public ServiceRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
