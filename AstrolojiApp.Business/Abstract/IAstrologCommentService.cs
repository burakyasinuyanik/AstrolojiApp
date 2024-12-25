using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IAstrologCommentService
{
    Task<AstrologCommentDto> CreateAsync(AstrologCommentCreateDto astrologCommentCreateDto);

    Task<AstrologCommentDto> UpdateAsync(AstrologCommentUpdateDto   astrologCommentUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<AstrologCommentDto>> GetAstrologCommentAsync();
   

    Task<AstrologCommentDto> GetByIdAsync(int id);


}
