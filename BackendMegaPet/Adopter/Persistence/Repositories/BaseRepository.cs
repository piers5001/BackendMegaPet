using BackendMegaPet.Adopter.Persistence.Contexts;

namespace BackendMegaPet.Adopter.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}