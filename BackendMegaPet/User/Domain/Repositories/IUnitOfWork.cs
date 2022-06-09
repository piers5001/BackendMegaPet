namespace BackendMegaPet.User.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}