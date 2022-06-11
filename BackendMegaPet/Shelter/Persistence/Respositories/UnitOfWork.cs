using BackendMegaPet.Shelter.Domain.Repositories;
using BackendMegaPet.Shelter.Persistence.Contexts;

namespace BackendMegaPet.Shelter.Persistence.Respositories;

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