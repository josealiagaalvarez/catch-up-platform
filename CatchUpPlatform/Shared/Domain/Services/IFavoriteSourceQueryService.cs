using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Queries;

namespace CatchUpPlatform.Shared.Domain.Services;

public interface IFavoriteSourceQueryService
{
    Task<IEnumerable<FavoriteSource?>> Handle(GetAllFavoriteSourceByNewsApiKeyQuery query);
    Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
}