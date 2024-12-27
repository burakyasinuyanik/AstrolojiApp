using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class DailyNewService : IDailyNewService
{
    private readonly IDailyNewRepository _dailyNewRepository;

    public DailyNewService(IDailyNewRepository dailyNewRepository)
    {
        _dailyNewRepository = dailyNewRepository;
    }

    public async Task<DailyNewDto> CreateAsync(DailyNewCreateDto dailyNewCreateDto)
    {
        var dailynew = new DailyNew
        {
            Text = dailyNewCreateDto.Text,
            Title = dailyNewCreateDto.Title
        };
        await _dailyNewRepository.AddAsync(dailynew);

        var dailyNewDto = new DailyNewDto
        {
            Id = dailynew.Id,
            Text = dailynew.Text,
            Title = dailynew.Title
        };
        return dailyNewDto;

    }

    public async Task DeleteAsync(int id)
    {
        var dailynew = await _dailyNewRepository.GetAsync(id);

        if (dailynew != null)
        {
            await _dailyNewRepository.DeleteAsync(dailynew);
        }

    }

    public async Task<DailyNewDto> GetByIdAsync(int id)
    {
        var dailynew = await _dailyNewRepository.GetAsync(id);

        var dailyNewDto = new DailyNewDto
        {
            Id = dailynew.Id,
            Text = dailynew.Text,
            Title = dailynew.Title
        };
        return dailyNewDto;
    }

    public async Task<IEnumerable<DailyNewDto>> GetDailyNewAsync()
    {
        IEnumerable<DailyNew> dailynew = await _dailyNewRepository.GetAllAsync();

        if (dailynew == null)
        {
            return null;
        }

        var dailynewdto = dailynew
                          .Select(x => new DailyNewDto
                          {
                              Id = x.Id,
                              Text = x.Text,
                              Title = x.Title
                          }).ToList();
        return dailynewdto;
    }

    public async Task<DailyNewDto> UpdateAsync(DailyNewUpdateDto dailyNewUpdateDto)
    {
        var dailynew = new DailyNew
        {
            Id = dailyNewUpdateDto.Id,
            Text = dailyNewUpdateDto.Text,
            Title = dailyNewUpdateDto.Title
        };
        await _dailyNewRepository.GetAsync(dailynew.Id);
        if (dailynew.Id == null)
        {
            return null;
        }
        await _dailyNewRepository.UpdateAsync(dailynew);

        var dailynewdto = new DailyNewDto
        {
            Id = dailynew.Id,
            Text = dailynew.Text,
            Title = dailynew.Title
        };
        return dailynewdto;
    }
}
