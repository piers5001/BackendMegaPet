using AutoMapper;
using BackendMegaPet.Adopter.Resources;

namespace BackendMegaPet.Adopter.Mapping;
using BackendMegaPet.Adopter.Domain.Models;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Adopter, AdopterResource>();
    }
}