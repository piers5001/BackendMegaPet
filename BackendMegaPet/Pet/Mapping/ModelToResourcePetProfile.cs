using AutoMapper;
using BackendMegaPet.Pet.Resources;

namespace BackendMegaPet.Pet.Mapping;
using BackendMegaPet.Pet.Domain.Models;
public class ModelToResourcePetProfile : Profile
{
    public ModelToResourcePetProfile()
    {
        CreateMap<Pet, PetResource>();
    }
}