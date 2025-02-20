using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class HoroscopeCommentService : IHoroscopeCommentService
{
    private readonly IHoroscopeCommentRepository _horoscopeCommenRepository;

    public HoroscopeCommentService(IHoroscopeCommentRepository horoscopeCommenRepository)
    {
        _horoscopeCommenRepository = horoscopeCommenRepository;
    }

    public async Task<HoroscopeCommentDto> CreateAsync(HoroscopeCommentCreateDto horoscopeCommentCreateDto)
    {
        var HoroscopeComment = new HoroscopeComment
        {
            HoroscopeId = horoscopeCommentCreateDto.HoroscopeId,
            Daily = horoscopeCommentCreateDto.Daily,
            Monthly = horoscopeCommentCreateDto.Monthly,
            Annual = horoscopeCommentCreateDto.Annual,
            Name = horoscopeCommentCreateDto.Name
        };
        await _horoscopeCommenRepository.AddAsync(HoroscopeComment);
        var horoscopeCommentDto = new HoroscopeCommentDto
        {
            Id = HoroscopeComment.Id,
            HoroscopeId = HoroscopeComment.HoroscopeId,
            Daily = HoroscopeComment.Daily,
            Monthly = HoroscopeComment.Monthly,
            Annual = HoroscopeComment.Annual,
            Name = HoroscopeComment.Name
        };
        return horoscopeCommentDto;

    }

    public async Task DeleteAsync(int id)
    {
        var HoroscopeComment = await _horoscopeCommenRepository.GetAsync(id);
        if (HoroscopeComment != null)
        {
            await _horoscopeCommenRepository.DeleteAsync(HoroscopeComment);
        }
        {

        }
    }

    public async Task<HoroscopeCommentDto> GetByIdAsync(int id)
    {
        var HoroscopeComment = await _horoscopeCommenRepository.GetAsync(id);
        var horoscopeCommentDto = new HoroscopeCommentDto
        {
            Id = HoroscopeComment.Id,
            HoroscopeId = HoroscopeComment.HoroscopeId,
            Daily = HoroscopeComment.Daily,
            Monthly = HoroscopeComment.Monthly,
            Annual = HoroscopeComment.Annual,
            Name = HoroscopeComment.Name
        };
        return horoscopeCommentDto;
    }

    public async Task<IEnumerable<HoroscopeCommentDto>> GetHoroscopeCommentAsync()
    {
        IEnumerable<HoroscopeComment> HoroscopeComment = await _horoscopeCommenRepository.GetAllAsync();
        if (HoroscopeComment == null)
        {
            return null;
        }
        var horoscopeCommentDto = HoroscopeComment
            .Select(x => new HoroscopeCommentDto
            {
                Id = x.Id,
                HoroscopeId = x.HoroscopeId,
                Daily = x.Daily,
                Monthly = x.Monthly,
                Annual = x.Annual,
                Name = x.Name
            }).ToList();
        return horoscopeCommentDto;
    }

    public async Task<HoroscopeCommentDto> UpdateAsync(HoroscopeCommentUpdateDto horoscopeCommentUpdateDto)
    {
        var HoroscopeComment = new HoroscopeComment
        {
            Id = horoscopeCommentUpdateDto.Id,
            HoroscopeId = horoscopeCommentUpdateDto.HoroscopeId,
            Daily = horoscopeCommentUpdateDto.Daily,
            Monthly = horoscopeCommentUpdateDto.Monthly,
            Annual = horoscopeCommentUpdateDto.Annual,
            Name = horoscopeCommentUpdateDto.Name
        };
        await _horoscopeCommenRepository.GetAsync(HoroscopeComment.Id);
        if (HoroscopeComment.Id == null)
        {
            return null;
        }
        await _horoscopeCommenRepository.UpdateAsync(HoroscopeComment);
        var horoscopeCommentDto = new HoroscopeCommentDto
        {
            Id = HoroscopeComment.Id,
            HoroscopeId = HoroscopeComment.HoroscopeId,
            Daily = HoroscopeComment.Daily,
            Monthly = HoroscopeComment.Monthly,
            Annual = HoroscopeComment.Annual,
            Name = HoroscopeComment.Name
        };
        return horoscopeCommentDto;
    }
}
