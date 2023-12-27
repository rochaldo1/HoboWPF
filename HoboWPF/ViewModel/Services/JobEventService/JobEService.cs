using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.JobEventService
{
    public class JobEService : IJobEService
    {
        public JobEService() { }
        public static JobEService Instance() => new JobEService();
        public bool TryJobEvent(int number, IDataManager dataManager)
        {
            dataManager.JobEvents.ApplyEffect(dataManager._concreteHobo, number);
            dataManager.ConcreteEvent = dataManager.JobEvents.EventsList.GetEvent(number);
            if (dataManager._concreteHobo.Health == 0 || dataManager._concreteHobo.Health < 0) return false;
            if (!dataManager.hoboRepository.Update(dataManager._concreteHobo)) return false;
            if (!dataManager.hoboRepository.Save()) return false;
            return true;
        }
    }
}
