using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface ISocialMediaService
{
    Task<SocialMediaDto> CreateAsync(SocialMediaCreateDto  socialMediaCreateDto);

    Task<SocialMediaDto> UpdateAsync(SocialMediaUpdateDto  socialMediaUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<SocialMediaDto>> GetSocialMediaAsync();


    Task<SocialMediaDto> GetByIdAsync(int id);
}
