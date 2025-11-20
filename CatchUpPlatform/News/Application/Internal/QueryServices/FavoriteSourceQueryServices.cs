using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Queries;
using CatchUpPlatform.News.Domain.Repositories;
using CatchUpPlatform.Shared.Domain.Services;

namespace CatchUpPlatform.News.Application.Internal.QueryServices;

public class FavoriteSourceQueryServices(
    IFavoriteSourceRepository favoriteSourceRepositoryrepository) : IFavoriteSourceQueryService
{
    public async Task<IEnumerable<FavoriteSource?>> Handle(GetAllFavoriteSourceByNewsApiKeyQuery query)
    {
        return await favoriteSourceRepositoryrepository.FindByNewsApiKeyAsync(query.NewsApiKey);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
    {
        return await favoriteSourceRepositoryrepository.FindByNewsApiKeyAndSourceIdAsync(query.NewsApiKey, query.SourceId);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
    {
        return await favoriteSourceRepositoryrepository.FindByIdAsync(query.Id);
    }
}