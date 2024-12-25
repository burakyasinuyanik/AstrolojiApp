using System;

namespace AstrolojiApp.Data.Abstract;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();//T�m kay�tlar� getirir
    Task<T?> GetAsync(int id);//id id'li kayd� getir
    Task AddAsync(T entity);//yeni kay�t
    Task UpdateAsync(T entity);//g�ncelleme
    Task DeleteAsync(T entity);//id id'li kayd� sil


}
