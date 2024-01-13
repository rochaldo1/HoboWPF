using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services
{
    public interface IAddHoboService
    {
        public bool AddHobo(string name, IDataManager dataManager);
    }
}
