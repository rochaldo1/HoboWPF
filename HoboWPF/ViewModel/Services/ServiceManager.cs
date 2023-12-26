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

namespace HoboWPF.ViewModel.Services
{
    public class ServiceManager : IServiceManager
    {
        IDataManager dataManager;
        ITakeHoboService takeHoboService;
        IAlmsEventService almsEventService;
        IDeleteHoboService deleteHoboService;
        IAddHoboService addHoboService;
        public ServiceManager(IDataManager dataManager, ITakeHoboService takeHoboService, IAlmsEventService almsEventService, IDeleteHoboService deleteHoboService, IAddHoboService addHoboService)
        {
            this.dataManager = dataManager;
            this.takeHoboService = takeHoboService;
            this.almsEventService = almsEventService;
            this.deleteHoboService = deleteHoboService;
            this.addHoboService = addHoboService;
        }
        public static ServiceManager Instanse(IDataManager dataManager, ITakeHoboService takeHoboService,IAlmsEventService almsEventService, IDeleteHoboService deleteHoboService,IAddHoboService addHoboService) => new(dataManager, takeHoboService, almsEventService, deleteHoboService,addHoboService);

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
