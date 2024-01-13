using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.JobEventService
{
    public interface IJobEService
    {
        public bool TryJobEvent(int number, IDataManager dataManager);
    }
}
