using AutoMapper;
using BackendMegaPet.Adopter.Resources;
namespace BackendMegaPet.Adopter.Mapping;
using BackendMegaPet.Adopter.Domain.Models;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveAdopterResource, Adopter>();
    }
}