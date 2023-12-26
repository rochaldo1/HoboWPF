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
using HoboWPF.ViewModel.Services.JobEventService;
using HoboWPF.ViewModel.Services.UseItemServices;

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
        IJobEService jobEService;
        IUseItemService useItemService;
        public ServiceManager(IDataManager dataManager, ITakeHoboService takeHoboService, IAlmsEventService almsEventService, IDeleteHoboService deleteHoboService, IAddHoboService addHoboService, IGarbageEService garbageEService, IJobEService jobEService, IUseItemService useItemService)
        {
            this.dataManager = dataManager;
            this.takeHoboService = takeHoboService;
            this.almsEventService = almsEventService;
            this.deleteHoboService = deleteHoboService;
            this.addHoboService = addHoboService;
            this.garbageEService = garbageEService;
            this.jobEService = jobEService;
            this.useItemService = useItemService;
        }
        public static ServiceManager Instanse(IDataManager dataManager, ITakeHoboService takeHoboService,IAlmsEventService almsEventService, IDeleteHoboService deleteHoboService,IAddHoboService addHoboService, IGarbageEService garbageEService, IJobEService jobEService,IUseItemService useItemService) => new(dataManager, takeHoboService, almsEventService, deleteHoboService,addHoboService,garbageEService, jobEService,useItemService);

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

        public bool TryJobEvents()
        {
            Random random = new Random();
            dataManager.JobEvents = dataManager.JobEventsRepository.GetJobEvents();
            int number = random.Next(0, GetCount.GetCountOf(dataManager.JobEvents.EventsList));
            return jobEService.TryJobEvent(number, dataManager);
        }

        public void DeleteHobo()
        {
            deleteHoboService.DeleteHobo(dataManager);
        }

        public bool TryAddHobo(string name)
        {
            return addHoboService.AddHobo(name, dataManager);
        }

        public bool TryUseItem(int index)
        {
            return useItemService.UseItem(index, dataManager);
        }

        public bool TrySellItem(int index)
        {
            return useItemService.SellItem(index, dataManager);
        }
    }
}
