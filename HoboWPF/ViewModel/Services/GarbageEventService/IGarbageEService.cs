using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.GarbageEventService
{
    public interface IGarbageEService
    {
        public bool TryGarbageEvent(int number, IDataManager dataManager);
    }
}
