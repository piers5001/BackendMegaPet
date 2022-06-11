using BackendMegaPet.Shelter.Persistence.Contexts;
namespace BackendMegaPet.Shelter.Persistence.Respositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}