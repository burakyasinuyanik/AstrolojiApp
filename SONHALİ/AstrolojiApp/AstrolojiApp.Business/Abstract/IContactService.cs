using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IContactService
{
    Task<ContactDto> CreateAsync(ContactCreateDto  contactCreateDto);

    Task<ContactDto> UpdateAsync(ContactUpdateDto  contactUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<ContactDto>> GetContacAsync();


    Task<ContactDto> GetByIdAsync(int id);

}
