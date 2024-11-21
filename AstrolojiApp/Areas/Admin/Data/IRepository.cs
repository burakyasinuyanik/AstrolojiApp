using System;

namespace AstrolojiApp.Areas.Admin.Data;

public interface IRepository<T> where T: class
{
    Task<IEnumerable<T>> GetAllAsync();//T�m kay�tlar� getirir
    Task<T?> GetAsync(int id);//id id'li kayd� getir
    Task<int> AddAsync(T entity);//yeni kay�t
    Task<int> UpdateAsync(T entity);//g�ncelleme
    Task<int> DeleteAsync(int id);//id id'li kayd� sil
  
}
