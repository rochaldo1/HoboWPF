using HoboWPF.ViewModel.DataManager;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Model.InventoryFolder;

namespace HoboWPF.ViewModel.Services.AddHoboService
{
    public class AddHoboService : IAddHoboService
    {
        public AddHoboService() { }
        public static AddHoboService Instance() => new();

        public bool AddHobo(string name, IDataManager dataManager)
        {
            Inventory inventory = new();
            Hobo hobo = new(Guid.NewGuid(), name, 100, 100, 100, 100, 300, inventory);
            if (!dataManager.hoboRepository.Add(hobo)) return false;
            dataManager.hoboRepository.Save();
            return true;
        }
    }
}
