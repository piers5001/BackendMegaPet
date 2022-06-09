using BackendMegaPet.User.Domain.Repositories;
using BackendMegaPet.User.Persistence.Contexts;

namespace BackendMegaPet.User.Persistence.Repositories;

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