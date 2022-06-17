using BackendMegaPet.Shared.Persistence.Repositories;
using BackendMegaPet.Shared.Persistence.Contexts;
using BackendMegaPet.User.Domain.Repositories;
using BackendMegaPet.User.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.User.Persistence.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Domain.Models.User>> ListAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task AddAsync(Domain.Models.User user)
    {
        await _context.Users.AddAsync(user);
    }

    public async Task<Domain.Models.User> FindByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public void Update(Domain.Models.User user)
    {
        _context.Users.Update(user);
    }

    public void Remove(Domain.Models.User user)
    {
        _context.Users.Remove(user);
    }
}