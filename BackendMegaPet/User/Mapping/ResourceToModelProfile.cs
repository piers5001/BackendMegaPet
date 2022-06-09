using AutoMapper;
using BackendMegaPet.User.Resources;
namespace BackendMegaPet.User.Mapping;
using BackendMegaPet.User.Domain.Models;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveUserResource, User>();
    }
}