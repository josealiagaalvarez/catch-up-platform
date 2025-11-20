using CatchUpPlatform.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.News.Domain.Repositories;

public interface IFavoriteSourceRepository
{
    Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId);
    Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey);
}