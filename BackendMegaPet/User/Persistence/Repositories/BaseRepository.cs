using BackendMegaPet.User.Persistence.Contexts;

namespace BackendMegaPet.User.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}