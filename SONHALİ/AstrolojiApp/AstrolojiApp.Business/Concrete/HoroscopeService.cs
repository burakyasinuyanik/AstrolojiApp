using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class HoroscopeService : IHoroscopeService
{
private readonly IHoroscopeRepository _horoscopeRepository;

    public HoroscopeService(IHoroscopeRepository horoscopeRepository)
    {
        _horoscopeRepository = horoscopeRepository;
    }

    public async Task<HoroscopeDto> CreateAsync(HoroscopeCreateDto horoscopeCreateDto)
    {
        var horoscope = new Horoscope
        {
            Name = horoscopeCreateDto.Name,
            Image = horoscopeCreateDto.Image,
            DateRange = horoscopeCreateDto.DateRange
        };
        await _horoscopeRepository.AddAsync(horoscope);

        var horoscopeDto = new HoroscopeDto
        {
            Id = horoscope.Id,
            Name = horoscope.Name,
            Image = horoscope.Image,
            DateRange = horoscope.DateRange
        };
        return horoscopeDto;
    }   

    public async Task DeleteAsync(int id)
    {
        var horoscope = await _horoscopeRepository.GetAsync(id);

        if (horoscope != null)
        {
            await _horoscopeRepository.DeleteAsync(horoscope);
        }
    }

    public async Task<HoroscopeDto> GetByIdAsync(int id)
    {
        var horoscope = await _horoscopeRepository.GetAsync(id);

        var horoscopeDto = new HoroscopeDto
        {
            Id = horoscope.Id,
            Name = horoscope.Name,
            Image = horoscope.Image,
            DateRange = horoscope.DateRange
        };
        return horoscopeDto;
    }

    public async Task<IEnumerable<HoroscopeDto>> GetHoroscopeAsync()
    {
        IEnumerable<Horoscope> horoscope = await _horoscopeRepository.GetAllAsync();
        if (horoscope == null)
        {
            return null;
        }
        var horoscopeDto = horoscope.Select(x => new HoroscopeDto
        {
            Id = x.Id,
            Name = x.Name,
            Image = x.Image,
            DateRange = x.DateRange
        });
        return horoscopeDto;
    }

    public async Task<HoroscopeDto> UpdateAsync(HoroscopeUpdateDto horoscopeUpdateDto)
    {
     var horoscope = new Horoscope
     {
         Id = horoscopeUpdateDto.Id,
         Name = horoscopeUpdateDto.Name,
         Image = horoscopeUpdateDto.Image,
         DateRange = horoscopeUpdateDto.DateRange
     };
     await _horoscopeRepository.GetAsync(horoscope.Id);
     if (horoscope.Id==null)
     {
        return null;
     }   
     await _horoscopeRepository.UpdateAsync(horoscope);
     var horoscopeDto = new HoroscopeDto
     {
         Id = horoscope.Id,
         Name = horoscope.Name,
         Image = horoscope.Image,
         DateRange = horoscope.DateRange
     };
     return horoscopeDto;
    }
}
