using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;

    public ContactService(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public Task<ContactDto> CreateAsync(ContactCreateDto contactCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ContactDto>> GetContacAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> UpdateAsync(ContactUpdateDto contactUpdateDto)
    {
        throw new NotImplementedException();
    }
}
