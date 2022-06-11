using BackendMegaPet.Adopter.Domain.Services.Communication;

namespace BackendMegaPet.Adopter.Domain.Services;
using BackendMegaPet.Adopter.Domain.Models;
public interface IAdopterService
{
    Task<IEnumerable<Adopter>> ListAsync();
    Task<AdopterResponse> SaveAsync(Adopter adopter);
    Task<AdopterResponse> UpdateAsync(int id, Adopter adopter);
    Task<AdopterResponse> DeleteAsync(int id);
}