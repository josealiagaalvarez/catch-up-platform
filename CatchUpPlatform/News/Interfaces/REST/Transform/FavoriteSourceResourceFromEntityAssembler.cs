using CatchUpPlatform.News.Domain.Model.Aggregates;

using CatchUpPlatform.News.Interfaces.REST.Resources;

namespace CatchUpPlatform.News.Interfaces.REST.Transform;

public static class FavoriteSourceResourceFromEntityAssembler
{
    public static FavoriteSourceResource ToResourceFromEntity(FavoriteSource entity)
    {
        return new FavoriteSourceResource(entity.Id, entity.NewsApiKey, entity.SourceId);
    }
}