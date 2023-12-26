using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.JobEventService
{
    public interface IJobEService
    {
        public bool TryJobEvent(int number, IDataManager dataManager);
    }
}
