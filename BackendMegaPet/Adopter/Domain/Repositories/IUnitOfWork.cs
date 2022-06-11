namespace BackendMegaPet.Adopter.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}