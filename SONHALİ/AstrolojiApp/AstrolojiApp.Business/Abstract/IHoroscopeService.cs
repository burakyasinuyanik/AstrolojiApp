using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IHoroscopeService
{
    Task<HoroscopeDto> CreateAsync(HoroscopeCreateDto  horoscopeCreateDto);

    Task<HoroscopeDto> UpdateAsync(HoroscopeUpdateDto  horoscopeUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<HoroscopeDto>> GetHoroscopeAsync();


    Task<HoroscopeDto> GetByIdAsync(int id);
}
