using BackendMegaPet.Shelter.Domain.Services.Communication;
namespace BackendMegaPet.Shelter.Domain.Services;
using BackendMegaPet.Shelter.Domain.Models;
public interface IShelterService
{
    Task<IEnumerable<Shelter>> ListAsync();
    Task<ShelterResponse> SaveAsync(Shelter shelter);
    Task<ShelterResponse> UpdateAsync(int id, Shelter shelter);
    Task<ShelterResponse> DeleteAsync(int id);
}