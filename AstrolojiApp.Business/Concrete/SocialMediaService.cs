using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class SocialMediaService : ISocialMediaService
{
    private readonly ISocialMediaRepository _socialMediaRepository;

    public SocialMediaService(ISocialMediaRepository socialMediaRepository)
    {
        _socialMediaRepository = socialMediaRepository;
    }

    public async Task<SocialMediaDto> CreateAsync(SocialMediaCreateDto socialMediaCreateDto)
    {
        var socialmedia = new SocialMedia
        {
            Name = socialMediaCreateDto.Name,
            Url = socialMediaCreateDto.Url,
            Icon = socialMediaCreateDto.Icon
        };
        await _socialMediaRepository.AddAsync(socialmedia);

        var socialMediaDto = new SocialMediaDto
        {
            Id = socialmedia.Id,
            Name = socialmedia.Name,
            Url = socialmedia.Url,
            Icon = socialmedia.Icon
        };
        return socialMediaDto;
    }

    public async Task DeleteAsync(int id)
    {
        var socialmedia = await _socialMediaRepository.GetAsync(id);
        if (socialmedia != null)
        {
            await _socialMediaRepository.DeleteAsync(socialmedia);
        }
    }

    public async Task<SocialMediaDto> GetByIdAsync(int id)
    {
        var socialmedia = await _socialMediaRepository.GetAsync(id);

        var socialMediaDto = new SocialMediaDto
        {
            Id = socialmedia.Id,
            Name = socialmedia.Name,
            Url = socialmedia.Url,
            Icon = socialmedia.Icon
        };
        return socialMediaDto;
    }

    public async Task<IEnumerable<SocialMediaDto>> GetSocialMediaAsync()
    {
        IEnumerable<SocialMedia> socialmedia = await _socialMediaRepository.GetAllAsync();
        if (socialmedia == null)
        {
            return null;
        }
        var socialMediaDtos = socialmedia.Select(socialmedia => new SocialMediaDto
        {
            Id = socialmedia.Id,
            Name = socialmedia.Name,
            Url = socialmedia.Url,
            Icon = socialmedia.Icon
        }).ToList();
        return socialMediaDtos;

    }

    public async Task<SocialMediaDto> UpdateAsync(SocialMediaUpdateDto socialMediaUpdateDto)
    {
        var socialmedia = new SocialMedia
        {
            Id = socialMediaUpdateDto.Id,
            Name = socialMediaUpdateDto.Name,
            Url = socialMediaUpdateDto.Url,
            Icon = socialMediaUpdateDto.Icon
        };
        await _socialMediaRepository.GetAsync(socialmedia.Id);
        if (socialmedia.Id == null)
        {
            return null;
        }
        await _socialMediaRepository.UpdateAsync(socialmedia);

        var socialMediaDto = new SocialMediaDto
        {
            Id = socialmedia.Id,
            Name = socialmedia.Name,
            Url = socialmedia.Url,
            Icon = socialmedia.Icon
        };
        return socialMediaDto;
    }
}
