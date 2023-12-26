using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.Services.UseItemServices
{
    public interface IUseItemService
    {
        public bool UseItem(int index, IDataManager dataManager);
        public bool SellItem(int index, IDataManager dataManager);
    }
}
