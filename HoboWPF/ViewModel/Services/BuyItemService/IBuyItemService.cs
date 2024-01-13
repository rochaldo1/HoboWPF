using HoboConsolePrjct.Model.Places;
using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.BuyItemService
{
    public interface IBuyItemService
    {
        public bool BuyItem(IPlace place, int index, IDataManager dataManager);
    }
}
