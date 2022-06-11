using BackendMegaPet.Shelter.Domain.Services.Communication;
namespace BackendMegaPet.Shelter.Domain.Services;
public interface IShelterService
{
    Task<IEnumerable<Models.Shelter>> ListAsync();
    Task<ShelterResponse> SaveAsync(Models.Shelter shelter);
    Task<ShelterResponse> UpdateAsync(int id, Models.Shelter shelter);
    Task<ShelterResponse> DeleteAsync(int id);
}