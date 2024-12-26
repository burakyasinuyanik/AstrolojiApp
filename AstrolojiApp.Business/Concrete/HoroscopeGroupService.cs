using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class HoroscopeGroupService : IHoroscopeGroupService
{
    private readonly IHoroscopeGroupRepository _horoscopeGroupRepository;

    public HoroscopeGroupService(IHoroscopeGroupRepository horoscopeGroupRepository)
    {
        _horoscopeGroupRepository = horoscopeGroupRepository;
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
