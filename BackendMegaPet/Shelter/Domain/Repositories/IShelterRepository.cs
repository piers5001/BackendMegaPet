namespace BackendMegaPet.Shelter.Domain.Repositories;
using BackendMegaPet.Shelter.Domain.Models;
public interface IShelterRepository
{
    Task<IEnumerable<Shelter>> ListAsync();
    Task AddAsync(Shelter shelter);
    Task<Shelter> FindShelterByIdAsync(int id);
    void UpdateShelter(Shelter shelter);
    void RemoveShelter(Shelter shelter);
}