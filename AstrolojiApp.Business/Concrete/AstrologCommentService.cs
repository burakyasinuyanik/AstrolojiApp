using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class AstrologCommentService : IAstrologCommentService
{

    private readonly IAstrologCommentRepository _astrologCommentRepository;

    public AstrologCommentService(IAstrologCommentRepository astrologCommentRepository)
    {
        _astrologCommentRepository = astrologCommentRepository;
    }

    public async Task<AstrologCommentDto> CreateAsync(AstrologCommentCreateDto astrologCommentCreateDto)
    {
        if (astrologCommentCreateDto == null)
        {
            return null;
        }

        var astrologcomments = new AstrologComment
        {
            Name = astrologCommentCreateDto.Name,
            Image = astrologCommentCreateDto.Image,
            Text = astrologCommentCreateDto.Text
        };
        await _astrologCommentRepository.AddAsync(astrologcomments);

        var astrologcommentDto = new AstrologCommentDto
        {
            Id = astrologcomments.Id,
            Name = astrologcomments.Name,
            Image = astrologcomments.Image,
            Text = astrologcomments.Text
        };

        return astrologcommentDto;

    }

    public async Task DeleteAsync(int id)
    {
        var astrcomment = await _astrologCommentRepository.GetAsync(id);
        if (astrcomment != null)
        {
            await _astrologCommentRepository.DeleteAsync(astrcomment);
        }
    }

    public async Task<IEnumerable<AstrologCommentDto>> GetAstrologCommentAsync()
    {
        IEnumerable<AstrologComment> astrologComment = await _astrologCommentRepository.GetAllAsync();
        var astrologCommentDto = astrologComment
                               .Select(x => new AstrologCommentDto
                               {
                                   Id = x.Id,
                                   Name = x.Name,
                                   Image = x.Image,
                                   Text = x.Text
                               }).ToList();
        return astrologCommentDto;


    }

    public async Task<AstrologCommentDto> GetByIdAsync(int id)
    {
        var astrolcomment = await _astrologCommentRepository.GetAsync(id);
        var astrologCommentDto = new AstrologCommentDto
        {
            Id = astrolcomment.Id,
            Name = astrolcomment.Name,
            Image = astrolcomment.Image,
            Text = astrolcomment.Text

        };
        return astrologCommentDto;
    }

    public async Task<AstrologCommentDto> UpdateAsync(AstrologCommentUpdateDto astrologCommentUpdateDto)
    {
        var astrgcomt = await _astrologCommentRepository.GetAsync(astrologCommentUpdateDto.Id);
        if (astrgcomt == null)
        {
            return null;
        }
        astrgcomt.Name = astrologCommentUpdateDto.Name;
        astrgcomt.Image = astrologCommentUpdateDto.Image;
        astrgcomt.Text = astrologCommentUpdateDto.Text;

            await _astrologCommentRepository.UpdateAsync(astrgcomt);

            var astrolgComntDto = new AstrologCommentDto
            {
                Id=astrgcomt.Id,
                Name=astrgcomt.Name,
                Image=astrgcomt.Image,
                Text = astrgcomt.Text
            };
            return astrolgComntDto;

    }
}
