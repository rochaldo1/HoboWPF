using HoboWPF.ViewModel.DataManager;
using HoboConsolePrjct.Model.Hobo;

namespace HoboWPF.ViewModel.Services.GoToHoboService
{
    public class TakeHoboService : ITakeHoboService
    {
        public TakeHoboService() { }
        public static TakeHoboService Instance() => new();

        public bool TakeHobo(Hobo hobo, IDataManager dataManager)
        {
            dataManager._concreteHobo = hobo;
            return true;
        }
    }
}
