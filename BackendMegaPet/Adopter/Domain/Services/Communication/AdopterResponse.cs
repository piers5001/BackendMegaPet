using BackendMegaPet.Shared.Domain.Services.Communication;

namespace BackendMegaPet.Adopter.Domain.Services.Communication;

public class AdopterResponse : BaseResponse<Models.Adopter>
{
    public AdopterResponse(Models.Adopter resource) : base(resource)
    {
    }

    public AdopterResponse(string message) : base(message)
    {
    }
}