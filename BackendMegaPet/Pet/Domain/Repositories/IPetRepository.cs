namespace BackendMegaPet.Pet.Domain.Repositories;
using BackendMegaPet.Pet.Domain.Models;
public interface IPetRepository
{
    Task<IEnumerable<Pet>> ListAsync();
    Task AddAsync(Pet pet);
    Task<Pet> FindPetByIdAsync(int id);
    void UpdatePet(Pet pet);
    void RemovePet(Pet pet);
}
