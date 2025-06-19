using CRGorman.Demo.ViewModels;

namespace CRGorman.Demo.ApiService.Hubs.Interface
{
    public interface ILiveHub
    {
        public Task LiveUpdate(MissionDto mission);
    }
}
