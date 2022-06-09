using BackendMegaPet.Shared.Domain.Services.Communication;

namespace BackendMegaPet.User.Domain.Services.Communication;

public class UserResponse : BaseResponse<Models.User>
{
    public UserResponse(Models.User resource) : base(resource)
    {
    }

    public UserResponse(string message) : base(message)
    {
    }
}