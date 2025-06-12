using CRGorman.Demo.ViewModels;

namespace CRGorman.Demo.Web;

public class GuideApiClient(HttpClient httpClient)
{

    public async Task<GameDto> GetGameAsync(int? gameId, CancellationToken cancellationToken = default)
    {
        
        GameDto? game = null;
        try
        {
            var jsonResponse = await httpClient.GetFromJsonAsync<GameDto>($"/game/{gameId}", cancellationToken);
            game = jsonResponse;
        }
        catch (Exception ex)
        {

        }
        return game;
    }


    public async Task<ActDto> GetActAsync(int? actId, CancellationToken cancellationToken = default)
    {
        ActDto? act = null;

        var jsonResponse = await httpClient.GetFromJsonAsync<ActDto>($"/act/{actId}", cancellationToken);
        act = jsonResponse;

        return act;
    }

    public async Task<MissionDto> GetMissionAsync(int? missionId, CancellationToken cancellationToken = default)
    {
        MissionDto? mission = null;

        var jsonResponse = await httpClient.GetFromJsonAsync<MissionDto>($"/mission/{missionId}", cancellationToken);
        mission = jsonResponse;

        return mission;
    }
}
