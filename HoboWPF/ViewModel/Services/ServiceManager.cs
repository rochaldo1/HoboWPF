using HoboConsolePrjct.Model.Hobo;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services.GoToHoboService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services
{
    public class ServiceManager : IServiceManager
    {
        IDataManager dataManager;
        ITakeHoboService takeHoboService;
        public ServiceManager(IDataManager dataManager, ITakeHoboService takeHoboService)
        {
            this.dataManager = dataManager;
            this.takeHoboService = takeHoboService;
        }
        public static ServiceManager Instanse(IDataManager dataManager, ITakeHoboService takeHoboService) => new(dataManager, takeHoboService);

        public bool TryTakeHobo(Hobo hobo)
        {
            return takeHoboService.TakeHobo(hobo, dataManager);
        }
    }
}
