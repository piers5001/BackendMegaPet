using BackendMegaPet.Adopter.Domain.Repositories;
using BackendMegaPet.Adopter.Persistence.Contexts;

namespace BackendMegaPet.Adopter.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}