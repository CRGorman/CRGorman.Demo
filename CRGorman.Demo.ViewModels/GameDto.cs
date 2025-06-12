namespace CRGorman.Demo.ViewModels;

public class GameDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string VanityURL { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Guide { get; set; } = string.Empty;

    /// <summary>
    /// The performance script to talk with.
    /// </summary>
    public string Script { get; set; } = string.Empty;

    public ICollection<ActDto> Acts { get; set; }

    public int Order { get; set; }
}
