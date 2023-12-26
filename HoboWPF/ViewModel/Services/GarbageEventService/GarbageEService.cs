using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HoboWPF.ViewModel.Services.GarbageEventService
{
    public class GarbageEService : IGarbageEService
    {
        public GarbageEService() { }
        public static GarbageEService Instance() => new();

        public bool TryGarbageEvent(int number, IDataManager dataManager)
        {
            dataManager.GarbageEvents.ApplyEffect(dataManager._concreteHobo, number);
            dataManager.ConcreteEvent = dataManager.GarbageEvents.EventsList.GetEvent(number);
            if (dataManager._concreteHobo.Health == 0 || dataManager._concreteHobo.Health < 0) return false;
            if (!dataManager.hoboRepository.Update(dataManager._concreteHobo)) return false;
            if (!dataManager.hoboRepository.Save()) return false;
            return true;
        }
    }
}
