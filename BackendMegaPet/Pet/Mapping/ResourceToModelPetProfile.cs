using AutoMapper;
using BackendMegaPet.Pet.Resources;
namespace BackendMegaPet.Pet.Mapping;
using BackendMegaPet.Pet.Domain.Models;

public class ResourceToModelPetProfile: Profile
{
    public ResourceToModelPetProfile()
    {
        CreateMap<SavePetResource, Pet>();
    }
    
}