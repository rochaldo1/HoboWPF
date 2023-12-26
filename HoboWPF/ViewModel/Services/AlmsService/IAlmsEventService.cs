using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.AlmsService
{
    public interface IAlmsEventService
    {
        public bool TryAlmsEvent(int number, IDataManager dataManager);
    }
}
