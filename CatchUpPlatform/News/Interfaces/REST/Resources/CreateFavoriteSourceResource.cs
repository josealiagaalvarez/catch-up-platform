using System.ComponentModel.DataAnnotations;

namespace CatchUpPlatform.News.Interfaces.REST.Resources;

public record CreateFavoriteSourceResource(
    [Required]string NewsApiKey,
    [Required]string SourceId
    );