using AutoMapper;
using CRGorman.Demo.SpeedrunData;
using CRGorman.Demo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CRGorman.Demo.ApiService.Services
{
    public class SpeedrunService(SpeedrunContext speedrunContext, IMapper mapper) : BaseService(mapper)
    {
        public async Task<List<GameDto>> GetTableOfContentsAsync()
        {
            try
            {
                //We want what would be the id numbers translated as vanity URLs.
                var data = await speedrunContext.Games
                    .Include(x => x.Acts).ThenInclude(y => y.Missions)
                    .ToListAsync();
                var retVal = mapper.Map<List<GameDto>>(data);
                return retVal;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<GameDto> GetGame(int id)
        {
            var retVal = mapper.Map<GameDto>(await speedrunContext.Games.Include(x=> x.Acts).ThenInclude(x=>x.Missions).FirstOrDefaultAsync(x => x.Id == id));
            return retVal;
        }

        public async Task<ActDto> GetActByGame(int gameId, int actNumber)
        {
            var retVal = mapper.Map<ActDto>(await speedrunContext.Acts.FirstOrDefaultAsync(x => x.GameId == gameId && x.ActNumber == actNumber));
            return retVal;
        }

        public async Task<ActDto> GetAct(int id)
        {
            var retVal = mapper.Map<ActDto>(await speedrunContext.Acts.Include(x => x.Missions).FirstOrDefaultAsync(x => x.Id == id));
            return retVal;
        }

        public async Task<MissionDto> GetMission(int id)
        {
            var retVal = mapper.Map<MissionDto>(await speedrunContext.Missions.FirstOrDefaultAsync(x => x.Id == id));
            return retVal;
        }

        public async Task<MissionDto> GetMissionByActByGame(int gameId, int actNumber, string missionName)
        {
            var retVal = mapper.Map<MissionDto>(await speedrunContext.Missions.FirstOrDefaultAsync(x => x.FileName == missionName && x.Act.ActNumber == actNumber && x.Act.GameId == gameId));
            return retVal;
        }
    }
}
