namespace BackendMegaPet.Adopter.Domain.Repositories;
using BackendMegaPet.Adopter.Domain.Models;

public interface IAdopterRepository
{
    Task<IEnumerable<Adopter>> ListAsync();
    Task AddAsync(Adopter adopter);
    Task<Adopter> FindByIdAsync(int id);
    void Update(Adopter adopter);
    void Remove(Adopter adopter);
}