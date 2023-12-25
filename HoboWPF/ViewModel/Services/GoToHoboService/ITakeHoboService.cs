using HoboConsolePrjct.Model.Hobo;
using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.GoToHoboService
{
    public interface ITakeHoboService
    {
        public bool TakeHobo(Hobo hobo, IDataManager dataManager);
    }
}
