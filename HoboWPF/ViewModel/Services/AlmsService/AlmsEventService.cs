using HoboConsole.Model.Items;
using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.AlmsService
{
    public class AlmsEventService : IAlmsEventService
    {
        public AlmsEventService() { }
        public static AlmsEventService Instance() => new();

        public bool TryAlmsEvent(int number, IDataManager dataManager)
        {
            dataManager.almsEvents.ApplyEffect(dataManager._concreteHobo, number);
            dataManager.ConcreteEvent = dataManager.almsEvents.EventsList.GetEvent(number);
            if (dataManager._concreteHobo.Health == 0 || dataManager._concreteHobo.Health < 0) return false;
            if (!dataManager.hoboRepository.Update(dataManager._concreteHobo)) return false;
            if (!dataManager.hoboRepository.Save()) return false;
            return true;
        }
    }
}
