namespace CatchUpPlatform.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}