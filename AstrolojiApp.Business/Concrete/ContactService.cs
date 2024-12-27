using System;
using System.Diagnostics.CodeAnalysis;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;

    public ContactService(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<ContactDto> CreateAsync(ContactCreateDto contactCreateDto)
    {
        if (contactCreateDto == null)
        {
            return null;
        }
        var contacts = new Contact
        {
            Address = contactCreateDto.Address,
            Icon = contactCreateDto.Icon,
            Map = contactCreateDto.Map,
            PhoneNumber = contactCreateDto.PhoneNumber
        };
        await _contactRepository.AddAsync(contacts);

        var contactDto = new ContactDto
        {
            Id = contacts.Id,
            Address = contacts.Address,
            Icon = contacts.Icon,
            Map = contacts.Map,
            PhoneNumber = contacts.PhoneNumber
        };
        return contactDto;
    }

    public async Task DeleteAsync(int id)
    {
        var contactId = await _contactRepository.GetAsync(id);
        if (contactId != null)
        {
            await _contactRepository.DeleteAsync(contactId);
        }

    }

    public async Task<ContactDto> GetByIdAsync(int id)
    {
        var contactReturn = await _contactRepository.GetAsync(id);
        if (contactReturn == null)
        {
            return null;

        }
        var contactDto = new ContactDto
        {
            Id = contactReturn.Id,
            Address = contactReturn.Address,
            Icon = contactReturn.Icon,
            Map = contactReturn.Map,
            PhoneNumber = contactReturn.PhoneNumber
        };
        return contactDto;
    }

    public async Task<IEnumerable<ContactDto>> GetContacAsync()
    {
        IEnumerable<Contact> contacts = await _contactRepository.GetAllAsync();
        var contactDtos = contacts.Select(x => new ContactDto
        {
            Id = x.Id,
            Address = x.Address,
            Icon = x.Icon,
            Map = x.Map,
            PhoneNumber = x.PhoneNumber
        }).ToList();

        return contactDtos;
    }

    public async Task<ContactDto> UpdateAsync(ContactUpdateDto contactUpdateDto)
    {
        var contactUpdate = await _contactRepository.GetAsync(contactUpdateDto.Id);
        if (contactUpdate == null)
        {
            return null;
        }
        contactUpdate.Address = contactUpdateDto.Address;
        contactUpdate.Icon = contactUpdateDto.Icon;
        contactUpdate.Map = contactUpdateDto.Map;
        contactUpdate.PhoneNumber = contactUpdateDto.PhoneNumber;
         await _contactRepository.UpdateAsync(contactUpdate);

        var contactDto = new ContactDto
        {
            Id = contactUpdate.Id,
            Address = contactUpdate.Address,
            Icon = contactUpdate.Icon,
            Map = contactUpdate.Map,
            PhoneNumber = contactUpdate.PhoneNumber
        };
        return contactDto;

    }
}
