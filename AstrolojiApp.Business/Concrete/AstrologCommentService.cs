using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class AstrologCommentService : IAstrologCommentService
{

    private readonly IAstrologCommentRepository _astrologCommentRepository;

    public AstrologCommentService(IAstrologCommentRepository astrologCommentRepository)
    {
        _astrologCommentRepository = astrologCommentRepository;
    }

    public Task<AstrologCommentDto> CreateAsync(AstrologCommentCreateDto astrologCommentCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AstrologCommentDto>> GetAstrologCommentAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AstrologCommentDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<AstrologCommentDto> UpdateAsync(AstrologCommentUpdateDto astrologCommentUpdateDto)
    {
        throw new NotImplementedException();
    }
}
