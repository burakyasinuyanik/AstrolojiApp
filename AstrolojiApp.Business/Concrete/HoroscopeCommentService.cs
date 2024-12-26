using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class HoroscopeCommentService : IHoroscopeCommentService
{
    private readonly IHoroscopeCommentRepository _horoscopeCommenRepository;

    public HoroscopeCommentService(IHoroscopeCommentRepository horoscopeCommenRepository)
    {
        _horoscopeCommenRepository = horoscopeCommenRepository;
    }

    public Task<HoroscopeCommentDto> CreateAsync(HoroscopeCommentCreateDto horoscopeCommentCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<HoroscopeCommentDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<HoroscopeCommentDto>> GetHoroscopeCommentAsync()
    {
        throw new NotImplementedException();
    }

    public Task<HoroscopeCommentDto> UpdateAsync(HoroscopeCommentUpdateDto horoscopeCommentUpdateDto)
    {
        throw new NotImplementedException();
    }
}
