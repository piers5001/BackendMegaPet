namespace BackendMegaPet.User.Domain.Services;
using BackendMegaPet.User.Domain.Models;
public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    
}