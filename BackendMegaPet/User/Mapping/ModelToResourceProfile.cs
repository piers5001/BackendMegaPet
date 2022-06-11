using AutoMapper;
using BackendMegaPet.Shelter.Domain.Services.Communication;
using BackendMegaPet.User.Resources;

namespace BackendMegaPet.User.Mapping;
using BackendMegaPet.User.Domain.Models;
using BackendMegaPet.Shelter.Domain.Models;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<User, UserResource>();
    }
}