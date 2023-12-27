using HoboConsolePrjct.Model.Places;
using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.BuyItemService
{
    public interface IBuyItemService
    {
        public bool BuyItem(IPlace place, int index, IDataManager dataManager);
    }
}
