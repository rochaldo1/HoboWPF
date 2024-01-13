using HoboConsolePrjct.Model.Hobo;
using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.GoToHoboService
{
    public interface ITakeHoboService
    {
        public bool TakeHobo(Hobo hobo, IDataManager dataManager);
    }
}
