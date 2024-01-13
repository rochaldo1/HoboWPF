using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.UseItemServices
{
    public interface IUseItemService
    {
        public bool UseItem(int index, IDataManager dataManager);
        public bool SellItem(int index, IDataManager dataManager);
    }
}
