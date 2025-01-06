using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class HoroscopeGroupService : IHoroscopeGroupService
{
    private readonly IHoroscopeGroupRepository _horoscopeGroupRepository;

    public HoroscopeGroupService(IHoroscopeGroupRepository horoscopeGroupRepository)
    {
        _horoscopeGroupRepository = horoscopeGroupRepository;
    }

    public async Task<HoroscopeGroupDto> CreateAsync(HoroscopeGroupCreateDto horoscopeGroupCreateDto)
    {
        var horoscopeGroup = new HoroscopeGroup
        {
            Name = horoscopeGroupCreateDto.Name,
            Image = horoscopeGroupCreateDto.Image,
            HoroscopeNames = horoscopeGroupCreateDto.HoroscopeNames
        };
        await _horoscopeGroupRepository.AddAsync(horoscopeGroup);
        var horoscopeGroupDto = new HoroscopeGroupDto
        {
            Id = horoscopeGroup.Id,
            Name = horoscopeGroup.Name,
            Image = horoscopeGroup.Image,
            HoroscopeNames = horoscopeGroup.HoroscopeNames
        };
        return horoscopeGroupDto;
    }

    public async Task DeleteAsync(int id)
    {
        var horoscopeGroup = await _horoscopeGroupRepository.GetAsync(id);
        if (horoscopeGroup != null)
        {
            await _horoscopeGroupRepository.DeleteAsync(horoscopeGroup);
        }
    }

    public async Task<HoroscopeGroupDto> GetByIdAsync(int id)
    {
        var horoscopeGroup = await _horoscopeGroupRepository.GetAsync(id);
        var horoscopeGroupDto = new HoroscopeGroupDto
        {
            Id = horoscopeGroup.Id,
            Name = horoscopeGroup.Name,
            Image = horoscopeGroup.Image,
            HoroscopeNames = horoscopeGroup.HoroscopeNames
        };
        return horoscopeGroupDto;
    }

    public async Task<IEnumerable<HoroscopeGroupDto>> GetHoroscopeGroupAsync()
    {
        IEnumerable<HoroscopeGroup> horoscopeGroups = await _horoscopeGroupRepository.GetAllAsync();
        if (horoscopeGroups == null)
        {
            return null;
        }

        var horoscopeGroupDtos = horoscopeGroups.Select(horoscopeGroup => new HoroscopeGroupDto
        {
            Id = horoscopeGroup.Id,
            Name = horoscopeGroup.Name,
            Image = horoscopeGroup.Image,
            HoroscopeNames = horoscopeGroup.HoroscopeNames
        }).ToList();
        return horoscopeGroupDtos;


    }

    public async Task<HoroscopeGroupDto> UpdateAsync(HoroscopeGroupUpdateDto horoscopeGroupUpdateDto)
    {
        var horoscopeGroup = new HoroscopeGroup
        {
            Id = horoscopeGroupUpdateDto.Id,
            Name = horoscopeGroupUpdateDto.Name,
            Image = horoscopeGroupUpdateDto.Image,
            HoroscopeNames = horoscopeGroupUpdateDto.HoroscopeNames
        };

        await _horoscopeGroupRepository.GetAsync(horoscopeGroup.Id);
        if (horoscopeGroup.Id == null)
        {
            return null;
        }
        await _horoscopeGroupRepository.UpdateAsync(horoscopeGroup);
        var horoscopeGroupDto = new HoroscopeGroupDto
        {
            Id = horoscopeGroup.Id,
            Name = horoscopeGroup.Name,
            Image = horoscopeGroup.Image,
            HoroscopeNames = horoscopeGroup.HoroscopeNames
        };
        return horoscopeGroupDto;
    }
}
