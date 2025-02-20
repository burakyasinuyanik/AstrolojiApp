using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Entity.Concrete;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class AstrologCommentRepository : GenericRepository<AstrologComment>, IAstrologCommentRepository
{
    public AstrologCommentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
