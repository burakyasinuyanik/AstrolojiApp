using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceService(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task<ServiceDto> CreateAsync(ServiceCreateDto serviceCreateDto)
    {
        var service = new Service
        {
            Name = serviceCreateDto.Name,
            Title = serviceCreateDto.Title
        };
        await _serviceRepository.AddAsync(service);

        var serviceDto = new ServiceDto
        {
            Id = service.Id,
            Name = service.Name,
            Title = service.Title
        };
        return serviceDto;
    }

    public async Task DeleteAsync(int id)
    {
        var service = await _serviceRepository.GetAsync(id);
        if (service != null)
        {
            await _serviceRepository.DeleteAsync(service);
        }
    }

    public async Task<ServiceDto> GetByIdAsync(int id)
    {
        var service = await _serviceRepository.GetAsync(id);

        var serviceDto = new ServiceDto
        {
            Id = service.Id,
            Name = service.Name,
            Title = service.Title
        };
        return serviceDto;
    }

    public async Task<IEnumerable<ServiceDto>> GetServiceAsync()
    {
        var services = await _serviceRepository.GetAllAsync();
        if (services == null)
        {
            return null;
        }


        var serviceDtos = services.Select(service => new ServiceDto
        {
            Id = service.Id,
            Name = service.Name,
            Title = service.Title
        }).ToList();
        return serviceDtos;
    }

    public async Task<ServiceDto> UpdateAsync(ServiceUpdateDto serviceUpdateDto)
    {
        var service = new Service
        {
            Id = serviceUpdateDto.Id,
            Name = serviceUpdateDto.Name,
            Title = serviceUpdateDto.Title
        };
        await _serviceRepository.GetAsync(service.Id);
        if (service.Id == null)
        {
            return null;
        }
        await _serviceRepository.UpdateAsync(service);
        var serviceDto = new ServiceDto
        {
            Id = service.Id,
            Name = service.Name,
            Title = service.Title
        };
        return serviceDto;
    }
}
