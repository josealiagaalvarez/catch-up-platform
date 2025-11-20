using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Commads;

namespace CatchUpPlatform.Shared.Domain.Services;

public interface IFavoriteSourceCommandService
{
    Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command);
}