using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class DailyNewService : IDailyNewService
{
    private readonly IDailyNewRepository _dailyNewRepository;

    public DailyNewService(IDailyNewRepository dailyNewRepository)
    {
        _dailyNewRepository = dailyNewRepository;
    }

    public Task<DailyNewDto> CreateAsync(DailyNewCreateDto dailyNewCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DailyNewDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DailyNewDto>> GetDailyNewAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DailyNewDto> UpdateAsync(DailyNewUpdateDto dailyNewUpdateDto)
    {
        throw new NotImplementedException();
    }
}
