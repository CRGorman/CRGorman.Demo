namespace CRGorman.Demo.ViewModels;
public class ActDto
{
    public int Id { get; set; }

    public int GameId { get; set; }
    
    public int ActNumber { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public List<MissionDto> Missions { get; set; }

    public int Order { get; set; }
}
