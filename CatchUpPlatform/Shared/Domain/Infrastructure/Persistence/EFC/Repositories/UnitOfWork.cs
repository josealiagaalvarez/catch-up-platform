using CatchUpPlatform.Shared.Domain.Infrastructure.Persistence.EFC.Configuration;
using CatchUpPlatform.Shared.Domain.Repositories;

namespace CatchUpPlatform.Shared.Domain.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    
    
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }

    
}