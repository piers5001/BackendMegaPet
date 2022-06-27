using BackendMegaPet.Shared.Persistence.Contexts;
using BackendMegaPet.Shared.Persistence.Repositories;
using BackendMegaPet.Pet.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.pet.Persistence.Respositories;

public class PetRepository : BaseRepository, IPetRepository
{
    public PetRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Pet.Domain.Models.Pet>> ListAsync()
    {
        return await _context.Pets.ToListAsync();
    }

    public async Task AddAsync(Pet.Domain.Models.Pet pet)
    {
        await _context.Pets.AddAsync(pet);
    }

    public async Task<Pet.Domain.Models.Pet> FindPetByIdAsync(int id)
    {
        return await _context.Pets.FindAsync(id);
    }

    public void UpdatePet(Pet.Domain.Models.Pet pet)
    {
        _context.Pets.Update(pet);
    }

    public void RemovePet(Pet.Domain.Models.Pet pet)
    {
        _context.Pets.Remove(pet);
    }
}