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

    public Task<IEnumerable<Pet.Domain.Models.Pet>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Pet.Domain.Models.Pet pet)
    {
        throw new NotImplementedException();
    }

    public Task<Pet.Domain.Models.Pet> FindPetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdatePet(Pet.Domain.Models.Pet pet)
    {
        throw new NotImplementedException();
    }

    public void RemovePet(Pet.Domain.Models.Pet pet)
    {
        throw new NotImplementedException();
    }
}