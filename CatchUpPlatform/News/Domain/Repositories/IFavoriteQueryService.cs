using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Queries;

namespace CatchUpPlatform.News.Domain.Repositories;

public interface IFavoriteQueryService
{
    Task<IEnumerable<FavoriteSource?>> Handle(GetAllFavoriteSourceByNewsApiKeyQuery query);
    Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
}