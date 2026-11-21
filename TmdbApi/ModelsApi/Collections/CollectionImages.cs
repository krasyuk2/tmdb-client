using TmdbApi.Models.Common;

namespace TmdbApi.Models.Collections;

public class CollectionImages
{
    public int Id { get; set; }
    public Image[]? Backdrops { get; set; }
    public Image[]? Posters { get; set; }
}
