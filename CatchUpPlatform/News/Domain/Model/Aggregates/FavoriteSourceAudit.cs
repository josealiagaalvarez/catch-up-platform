using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace CatchUpPlatform.News.Domain.Model.Aggregates;

public partial class FavoriteSource : IEntityWithCreatedUpdatedDate

{
    [Column(name:"CreatedAt")]public DateTimeOffset? CreatedDate { get; set; }
    [Column(name:"UpdatedAt")]public DateTimeOffset? UpdatedDate { get; set; }
}