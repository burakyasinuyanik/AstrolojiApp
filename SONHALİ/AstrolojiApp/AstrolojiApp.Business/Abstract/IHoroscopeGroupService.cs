using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IHoroscopeGroupService
{
    Task<HoroscopeGroupDto> CreateAsync(HoroscopeGroupCreateDto  horoscopeGroupCreateDto);

    Task<HoroscopeGroupDto> UpdateAsync(HoroscopeGroupUpdateDto horoscopeGroupUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<HoroscopeGroupDto>> GetHoroscopeGroupAsync();


    Task<HoroscopeGroupDto> GetByIdAsync(int id);
}
