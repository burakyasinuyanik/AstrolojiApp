using System;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IHoroscopeCommentService
{
    Task<HoroscopeCommentDto> CreateAsync(HoroscopeCommentCreateDto horoscopeCommentCreateDto);

    Task<HoroscopeCommentDto> UpdateAsync(HoroscopeCommentUpdateDto horoscopeCommentUpdateDto );

    Task DeleteAsync(int id);

    Task<IEnumerable<HoroscopeCommentDto>> GetHoroscopeCommentAsync();


    Task<HoroscopeCommentDto> GetByIdAsync(int id);
}
