using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IAppSettingService
{
    Task<AppSettingDto> CreateAsync(AppSettingCreateDto  appSettingCreateDto);

    Task<AppSettingDto> UpdateAsync(AppSettingUpdateDto  appSettingUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<AppSettingDto>> GetAppSettingAsync();


    Task<AppSettingDto> GetByIdAsync(int id);





}
