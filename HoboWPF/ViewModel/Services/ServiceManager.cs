using HoboConsolePrjct.Model.Hobo;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services.AlmsService;
using HoboWPF.ViewModel.Services.GoToHoboService;
using HoboConsolePrjct.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboWPF.ViewModel.Services.DeleteHoboService;
using HoboWPF.ViewModel.Services.GarbageEventService;

namespace HoboWPF.ViewModel.Services
{
    public class ServiceManager : IServiceManager
    {
        IDataManager dataManager;
        ITakeHoboService takeHoboService;
        IAlmsEventService almsEventService;
        IDeleteHoboService deleteHoboService;
        IAddHoboService addHoboService;
        IGarbageEService garbageEService;
        public ServiceManager(IDataManager dataManager, ITakeHoboService takeHoboService, IAlmsEventService almsEventService, IDeleteHoboService deleteHoboService, IAddHoboService addHoboService, IGarbageEService garbageEService)
        {
            this.dataManager = dataManager;
            this.takeHoboService = takeHoboService;
            this.almsEventService = almsEventService;
            this.deleteHoboService = deleteHoboService;
            this.addHoboService = addHoboService;
            this.garbageEService = garbageEService;
        }
        public static ServiceManager Instanse(IDataManager dataManager, ITakeHoboService takeHoboService,IAlmsEventService almsEventService, IDeleteHoboService deleteHoboService,IAddHoboService addHoboService, IGarbageEService garbageEService) => new(dataManager, takeHoboService, almsEventService, deleteHoboService,addHoboService,garbageEService);

        public bool TryTakeHobo(Hobo hobo)
        {
            return takeHoboService.TakeHobo(hobo, dataManager);
        }
        public bool TryAlmsEvent()
        {
            Random random = new Random();
            dataManager.almsEvents = dataManager.AlmsEventsRepository.GetAlmsEvents();
            int number = random.Next(0, GetCount.GetCountOf(dataManager.almsEvents.EventsList));
            return almsEventService.TryAlmsEvent(number, dataManager);
        }

        public bool TryGarbageEvent()
        {
            Random random = new Random();
            dataManager.GarbageEvents = dataManager.GarbageEventsRepository.GetGarbageEvents();
            int number = random.Next(0,GetCount.GetCountOf(dataManager.GarbageEvents.EventsList));
            return garbageEService.TryGarbageEvent(number, dataManager);

        }

        public void DeleteHobo()
        {
            deleteHoboService.DeleteHobo(dataManager);
        }

        public bool TryAddHobo(string name)
        {
            return addHoboService.AddHobo(name, dataManager);
        }
    }
}
