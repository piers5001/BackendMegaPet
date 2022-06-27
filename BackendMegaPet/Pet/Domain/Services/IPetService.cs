using BackendMegaPet.Pet.Domain.Services.Communication;
namespace BackendMegaPet.Pet.Domain.Services;
using BackendMegaPet.Pet.Domain.Models;
public interface IPetService
{
    Task<IEnumerable<Pet>> ListAsync();
    Task<PetResponse> SaveAsync(Pet pet);
    Task<PetResponse> UpdateAsync(int id, Pet pet);
    Task<PetResponse> DeleteAsync(int id);
}