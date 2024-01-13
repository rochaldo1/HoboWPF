using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.AlmsService
{
    public interface IAlmsEventService
    {
        public bool TryAlmsEvent(int number, IDataManager dataManager);
    }
}
