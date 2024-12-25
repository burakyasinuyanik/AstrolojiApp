using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using Microsoft.EntityFrameworkCore;

namespace AstrolojiApp.Data.Concrete.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly AppDbContext _appDbContext;

    private readonly DbSet<T> _dbset;
    
    public GenericRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
        _dbset = _appDbContext.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbset.AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbset.Remove(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result = await _dbset.ToListAsync();
        return result;
    }

    public async Task<T?> GetAsync(int id)
    {
        var result = await _dbset.FindAsync(id);
        return result;
    }

    public async Task UpdateAsync(T entity)
    {
        _dbset.Update(entity);
        await _appDbContext.SaveChangesAsync();
    }

    
}
