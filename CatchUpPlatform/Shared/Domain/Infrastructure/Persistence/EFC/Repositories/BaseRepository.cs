using CatchUpPlatform.Shared.Domain.Infrastructure.Persistence.EFC.Configuration;
using CatchUpPlatform.Shared.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CatchUpPlatform.Shared.Domain.Infrastructure.Persistence.EFC.Repositories;

public class BaseRepository <TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly DbContext Context;
    
    public BaseRepository (AppDbContext context)
    {
        this.Context = context;
    }
    
    public async Task AddAsync(TEntity entity)
    {
        await Context.Set<TEntity>().AddAsync(entity);
    }

    public async Task<IEnumerable<TEntity>> ListAsync()
    {
       return await Context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity?> FindByIdAsync(int id)
    {
        return await Context.Set<TEntity>().FindAsync(id);
    }

    public void Update(TEntity entity)
    {
        Context.Set<TEntity>().Update(entity);
    }

    public void Remove(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
    }
}