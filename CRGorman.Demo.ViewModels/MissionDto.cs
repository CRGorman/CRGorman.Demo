namespace CRGorman.Demo.ViewModels;

public class MissionDto
{
    public int Id { get; set; }
        
    public int ActId { get; set; }

    public string FileName { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Loadout { get; set; } = string.Empty;

    public string Guide { get; set; } = string.Empty;

    /// <summary>
    /// The performance script to talk with.
    /// </summary>
    public string Script { get; set; } = string.Empty;

    public int Order { get; set; }
}
