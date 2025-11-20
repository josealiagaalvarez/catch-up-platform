using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.Shared.Domain.Repositories;

namespace CatchUpPlatform.News.Domain.Repositories;

public interface IFavoriteSourceRepository : IBaseRepository<FavoriteSource>
{
    Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId);
    Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey);
}