using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class SocialMediaService : ISocialMediaService
{
    private readonly ISocialMediaRepository _socialMediaRepository;

    public SocialMediaService(ISocialMediaRepository socialMediaRepository)
    {
        _socialMediaRepository = socialMediaRepository;
    }

    public Task<SocialMediaDto> CreateAsync(SocialMediaCreateDto socialMediaCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SocialMediaDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SocialMediaDto>> GetSocialMediaAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SocialMediaDto> UpdateAsync(SocialMediaUpdateDto socialMediaUpdateDto)
    {
        throw new NotImplementedException();
    }
}
