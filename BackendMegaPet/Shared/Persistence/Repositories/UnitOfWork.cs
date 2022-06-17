using BackendMegaPet.Shared.Domain.Repositories;
using BackendMegaPet.Shared.Persistence.Contexts;

namespace BackendMegaPet.Shared.Persistence.Repositories;

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