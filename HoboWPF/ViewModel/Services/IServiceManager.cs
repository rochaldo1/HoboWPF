using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services
{
    public interface IServiceManager
    {
        public bool TryTakeHobo(Hobo hobo);
        public bool TryAlmsEvent();
        public bool TryGarbageEvent();
        public bool TryJobEvents();
        public void DeleteHobo();
        public bool TryAddHobo(string name);
        public bool TryUseItem(int index);
        public bool TrySellItem(int index);
    }
}
