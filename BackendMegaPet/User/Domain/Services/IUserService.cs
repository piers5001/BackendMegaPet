using BackendMegaPet.User.Domain.Services.Communication;

namespace BackendMegaPet.User.Domain.Services;
using BackendMegaPet.User.Domain.Models;
public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    Task<UserResponse> SaveAsync(User user);
    Task<UserResponse> UpdateAsync(int id, User user);
    Task<UserResponse> DeleteAsync(int id);
}