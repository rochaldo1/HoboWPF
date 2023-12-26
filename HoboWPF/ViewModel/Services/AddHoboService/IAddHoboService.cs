using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services
{
    public interface IAddHoboService
    {
        public bool AddHobo(string name, IDataManager dataManager);
    }
}
