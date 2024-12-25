using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Repositories;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class AppSettingService : IAppSettingService
{
    private readonly IAppSettingRepository _appSettingRepository;

    public AppSettingService(IAppSettingRepository appSettingRepository)
    {
        _appSettingRepository = appSettingRepository;
    }

    public async Task<AppSettingDto> CreateAsync(AppSettingCreateDto appSettingCreateDto)
    {
        if (appSettingCreateDto == null)
        {
            return null;
        }
        var appSetting = new AppSetting
        {
            WorkingHours = appSettingCreateDto.WorkingHours,
            BrandName = appSettingCreateDto.BrandName,
            ImageUrl = appSettingCreateDto.ImageUrl,
            Title = appSettingCreateDto.Title,
            AboutText = appSettingCreateDto.AboutText,
            HoroscopeName = appSettingCreateDto.HoroscopeName,
            PhoneNumber = appSettingCreateDto.PhoneNumber,
            Email = appSettingCreateDto.Email
        };
        await _appSettingRepository.AddAsync(appSetting);

        var appSettingDto = new AppSettingDto
        {
            WorkingHours = appSetting.WorkingHours,
            BrandName = appSetting.BrandName,
            ImageUrl = appSetting.ImageUrl,
            Title = appSetting.Title,
            AboutText = appSetting.AboutText,
            HoroscopeName = appSetting.HoroscopeName,
            PhoneNumber = appSetting.PhoneNumber,
            Email = appSetting.Email
        };
        return appSettingDto;

    }

    public async Task DeleteAsync(int id)
    {
        var appSetting = await _appSettingRepository.GetAsync(id);
        if (appSetting != null)
        {
            await _appSettingRepository.DeleteAsync(appSetting);
        }
    }

    public async Task<IEnumerable<AppSettingDto>> GetAppSettingAsync()
    {
        IEnumerable<AppSetting> appSettings = await _appSettingRepository.GetAllAsync();

        var appSettingDtos = appSettings.Select(x => new AppSettingDto
        {

            WorkingHours = x.WorkingHours,
            BrandName = x.BrandName,
            ImageUrl = x.ImageUrl,
            Title = x.Title,
            AboutText = x.AboutText,
            HoroscopeName = x.HoroscopeName,
            PhoneNumber = x.PhoneNumber,
            Email = x.Email
        }).ToList();
        return appSettingDtos;

    }

    public async Task<AppSettingDto> GetByIdAsync(int id)
    {
        var appSetting = await _appSettingRepository.GetAsync(id);
        if (appSetting == null)
        {
            return null;
        }

        var appSettingDto = new AppSettingDto
        {
            WorkingHours = appSetting.WorkingHours,
            BrandName = appSetting.BrandName,
            ImageUrl = appSetting.ImageUrl,
            Title = appSetting.Title,
            AboutText = appSetting.AboutText,
            HoroscopeName = appSetting.HoroscopeName,
            PhoneNumber = appSetting.PhoneNumber,
            Email = appSetting.Email
        };
        return appSettingDto;


    }

    public async Task<AppSettingDto> UpdateAsync(AppSettingUpdateDto appSettingUpdateDto)
    {
        var appSetting = await _appSettingRepository.GetAsync(appSettingUpdateDto.Id);

        if (appSetting == null)
        {
            return null;

        }
        appSetting.WorkingHours = appSettingUpdateDto.WorkingHours;
            appSetting.BrandName = appSettingUpdateDto.BrandName;
            appSetting.ImageUrl = appSettingUpdateDto.ImageUrl;
            appSetting.Title = appSettingUpdateDto.Title;
            appSetting.AboutText = appSettingUpdateDto.AboutText;
            appSetting.HoroscopeName = appSettingUpdateDto.HoroscopeName;
            appSetting.PhoneNumber = appSettingUpdateDto.PhoneNumber;
            appSetting.Email = appSettingUpdateDto.Email;
            await _appSettingRepository.UpdateAsync(appSetting);

            var appSettingDto = new AppSettingDto
            {
                WorkingHours = appSetting.WorkingHours,
                BrandName = appSetting.BrandName,
                ImageUrl = appSetting.ImageUrl,
                Title = appSetting.Title,
                AboutText = appSetting.AboutText,
                HoroscopeName = appSetting.HoroscopeName,
                PhoneNumber = appSetting.PhoneNumber,
                Email = appSetting.Email
            };
        return appSettingDto;



    }
}
