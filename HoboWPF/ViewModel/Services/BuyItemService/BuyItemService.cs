using HoboConsolePrjct.Model.Places;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services.AlmsService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.BuyItemService
{
    public class BuyItemService : IBuyItemService
    {
        public BuyItemService() { }
        public static BuyItemService Instance() => new();

        public bool BuyItem(IPlace place, int index, IDataManager dataManager)
        {
            if(!dataManager._concreteHobo.BuyItem(place, index)) return false;
            if(!dataManager.hoboRepository.Update(dataManager._concreteHobo)) return false;
            dataManager.hoboRepository.Save();
            return true;
        }
    }
}
