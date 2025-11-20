namespace CatchUpPlatform.News.Domain.Model.Commads;

public record CreateFavoriteSourceCommand(string NewsApiKey, string SourceId);