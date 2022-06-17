using BackendMegaPet.Adopter.Domain.Repositories;
using BackendMegaPet.Shared.Persistence.Contexts;
using BackendMegaPet.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.Adopter.Persistence.Repositories;

public class AdopterRepository : BaseRepository, IAdopterRepository
{
    public AdopterRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Domain.Models.Adopter>> ListAsync()
    {
        return await _context.Adopters.ToListAsync();
    }

    public async Task AddAsync(Domain.Models.Adopter adopter)
    {
        await _context.Adopters.AddAsync(adopter);
    }

    public async Task<Domain.Models.Adopter> FindByIdAsync(int id)
    {
        return await _context.Adopters.FindAsync(id);
    }

    public void Update(Domain.Models.Adopter adopter)
    {
        _context.Adopters.Update(adopter);
    }

    public void Remove(Domain.Models.Adopter adopter)
    {
        _context.Adopters.Remove(adopter);
    }
}