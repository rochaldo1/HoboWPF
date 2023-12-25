using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
