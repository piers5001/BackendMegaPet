using AutoMapper;
using BackendMegaPet.Shelter.Resources;
namespace BackendMegaPet.Shelter.Mapping;
using BackendMegaPet.Shelter.Domain.Models;

public class ResourceToModelShelterProfile: Profile
{
    public ResourceToModelShelterProfile()
    {
        CreateMap<SaveShelterResource, Shelter>();
    }
    
}