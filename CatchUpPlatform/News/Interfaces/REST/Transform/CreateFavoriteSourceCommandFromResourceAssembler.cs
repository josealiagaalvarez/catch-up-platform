using CatchUpPlatform.News.Domain.Model.Commads;
using CatchUpPlatform.News.Interfaces.REST.Resources;

namespace CatchUpPlatform.News.Interfaces.REST.Transform;

public static class CreateFavoriteSourceCommandFromResourceAssembler
{
    public static CreateFavoriteSourceCommand ToCommandFromResource(CreateFavoriteSourceResource resource)
    {
        return new CreateFavoriteSourceCommand(resource.NewsApiKey, resource.SourceId);
    }
}