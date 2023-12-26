using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.GarbageEventService
{
    public interface IGarbageEService
    {
        public bool TryGarbageEvent(int number, IDataManager dataManager);
    }
}
