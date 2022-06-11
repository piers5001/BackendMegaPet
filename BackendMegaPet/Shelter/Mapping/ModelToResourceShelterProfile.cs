using AutoMapper;
using BackendMegaPet.Shelter.Resources;
namespace BackendMegaPet.Shelter.Mapping;
using BackendMegaPet.Shelter.Domain.Models;
public class ModelToResourceShelterProfile : Profile
{
    public ModelToResourceShelterProfile()
    {
        CreateMap<Shelter, ShelterResource>();
    }
}