using System;

namespace AstrolojiApp.Areas.Admin.Data;

public interface IRepository<T> where T: class
{
    Task<IEnumerable<T>> GetAllAsync();
   
}
