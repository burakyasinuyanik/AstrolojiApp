using System;

namespace AstrolojiApp.Areas.Admin.Data;

public interface IRepository<T> where T: class
{
    Task<IEnumerable<T>> GetAllAsync();//Tüm kayýtlarý getirir
    Task<T?> GetAsync(int id);//id id'li kaydý getir
    Task<int> AddAsync(T entity);//yeni kayýt
    Task<int> UpdateAsync(T entity);//güncelleme
    Task<int> DeleteAsync(int id);//id id'li kaydý sil
  


}
