using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Commads;
using CatchUpPlatform.News.Domain.Repositories;
using CatchUpPlatform.Shared.Domain.Repositories;
using CatchUpPlatform.Shared.Domain.Services;

namespace CatchUpPlatform.News.Application.Internal.CommandSevice;

public class FavoriteSourceCommandService(
    IFavoriteSourceRepository favoriteSourceRepository,
    IUnitOfWork unitOfWork
    ) : IFavoriteSourceCommandService
{
    public async Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command)
    {
        var favoriteSource = await favoriteSourceRepository
            .FindByNewsApiKeyAndSourceIdAsync(command.NewsApiKey, command.SourceId);
        if (favoriteSource is not null)
        {
            throw new Exception("Favorite source with the same NewsApiKey and SourceId already exists.");
        }

       favoriteSource= new FavoriteSource(command);
       try
       {
           await favoriteSourceRepository.AddAsync(favoriteSource);
           await unitOfWork.CompleteAsync();
           return favoriteSource;
       }
       catch(Exception ex)
       {
           Console.Write("An error occurred while creating Favorite Source: " + ex.Message);
           return null;
       }
       
    }
}