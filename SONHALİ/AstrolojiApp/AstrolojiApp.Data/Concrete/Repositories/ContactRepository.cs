using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class ContactRepository : GenericRepository<Contact>, IContactRepository
{
    public ContactRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
