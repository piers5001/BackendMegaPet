using BackendMegaPet.Shared.Domain.Services.Communication;

namespace BackendMegaPet.Pet.Domain.Services.Communication;

public class PetResponse : BaseResponse<Models.Pet>
{
    public PetResponse(Models.Pet resource) : base(resource)
    {
    }

    public PetResponse(string message) : base(message)
    {
    }
}