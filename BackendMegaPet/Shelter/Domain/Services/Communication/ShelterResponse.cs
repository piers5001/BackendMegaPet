using BackendMegaPet.Shared.Domain.Services.Communication;

namespace BackendMegaPet.Shelter.Domain.Services.Communication;

public class ShelterResponse : BaseResponse<Models.Shelter>
{
    public ShelterResponse(Models.Shelter resource) : base(resource)
    {
    }

    public ShelterResponse(string message) : base(message)
    {
    }
}