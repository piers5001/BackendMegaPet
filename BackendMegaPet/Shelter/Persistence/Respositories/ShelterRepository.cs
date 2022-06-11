using BackendMegaPet.Shelter.Domain.Repositories;
using BackendMegaPet.Shelter.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.Shelter.Persistence.Respositories;

public class ShelterRepository : BaseRepository, IShelterRepository
{
    public ShelterRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Domain.Models.Shelter>> ListAsync()
    {
        return await _context.Shelters.ToListAsync();
    }

    public async Task AddAsync(Domain.Models.Shelter shelter)
    {
        await _context.Shelters.AddAsync(shelter);
    }

    public async Task<Domain.Models.Shelter> FindShelterByIdAsync(int id)
    {
        return await _context.Shelters.FindAsync(id);
    }

    public void UpdateShelter(Domain.Models.Shelter shelter)
    {
        _context.Shelters.Update(shelter);
    }

    public void RemoveShelter(Domain.Models.Shelter shelter)
    {
        _context.Shelters.Remove(shelter);
    }
}