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
    }
}
