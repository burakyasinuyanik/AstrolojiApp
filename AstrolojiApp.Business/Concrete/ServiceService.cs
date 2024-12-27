using System;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Concrete;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceService(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public Task<ServiceDto> CreateAsync(ServiceCreateDto serviceCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ServiceDto>> GetServiceAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ServiceDto> UpdateAsync(ServiceUpdateDto serviceUpdateDto)
    {
        throw new NotImplementedException();
    }
}
