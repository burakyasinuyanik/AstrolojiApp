using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class HoroscopeService : IHoroscopeGroupService
{
    private readonly IHoroscopeRepository _horoscopeRepository;

    public HoroscopeService(IHoroscopeRepository horoscopeRepository)
    {
        _horoscopeRepository = horoscopeRepository;
    }

    public Task<HoroscopeGroupDto> CreateAsync(HoroscopeGroupCreateDto horoscopeGroupCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<HoroscopeGroupDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<HoroscopeGroupDto>> GetHoroscopeGroupAsync()
    {
        throw new NotImplementedException();
    }

    public Task<HoroscopeGroupDto> UpdateAsync(HoroscopeGroupUpdateDto horoscopeGroupUpdateDto)
    {
        throw new NotImplementedException();
    }
}
