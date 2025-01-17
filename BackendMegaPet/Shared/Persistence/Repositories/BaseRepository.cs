﻿using BackendMegaPet.Shared.Persistence.Contexts;

namespace BackendMegaPet.Shared.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}