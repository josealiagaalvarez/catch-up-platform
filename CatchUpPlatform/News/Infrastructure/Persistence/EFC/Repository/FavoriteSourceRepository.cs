using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Repositories;
using CatchUpPlatform.Shared.Domain.Infrastructure.Persistence.EFC.Configuration;
using CatchUpPlatform.Shared.Domain.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CatchUpPlatform.News.Infrastructure.Persistence.EFC.Repository;

public class FavoriteSourceRepository (AppDbContext context) : 
    BaseRepository<FavoriteSource>(context), IFavoriteSourceRepository
{
    public async Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId)
    {
        return await Context.Set<FavoriteSource>().FirstOrDefaultAsync(f=>f.NewsApiKey == newsApiKey && f.SourceId == sourceId);
    }

    public async Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey)
    {
        return await Context.Set<FavoriteSource>().Where(f=>f.NewsApiKey == newsApiKey).ToListAsync();
    }
}