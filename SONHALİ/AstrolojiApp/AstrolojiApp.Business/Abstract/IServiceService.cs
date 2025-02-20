using System;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Business.Abstract;

public interface IServiceService
{
    Task<ServiceDto> CreateAsync(ServiceCreateDto  serviceCreateDto);

    Task<ServiceDto> UpdateAsync(ServiceUpdateDto  serviceUpdateDto);

    Task DeleteAsync(int id);

    Task<IEnumerable<ServiceDto>> GetServiceAsync();


    Task<ServiceDto> GetByIdAsync(int id);
}
