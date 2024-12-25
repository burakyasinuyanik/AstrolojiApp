using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IDailyNewService
{
    Task<DailyNewDto> CreateAsync(DailyNewCreateDto  dailyNewCreateDto);

    Task<DailyNewDto> UpdateAsync(DailyNewUpdateDto dailyNewUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<DailyNewDto>> GetDailyNewAsync();


    Task<DailyNewDto> GetByIdAsync(int id);

}
