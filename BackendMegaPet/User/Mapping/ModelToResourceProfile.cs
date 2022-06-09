using AutoMapper;
using BackendMegaPet.User.Resources;

namespace BackendMegaPet.User.Mapping;
using BackendMegaPet.User.Domain.Models;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<User, UserResource>();
    }
}