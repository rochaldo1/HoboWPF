using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.UseItemServices
{
    public class UseItemService : IUseItemService
    {
        public UseItemService() { }
        public static UseItemService Instanse() => new();

        public bool UseItem(int index, IDataManager dataManager)
        {
            if(!dataManager._concreteHobo.UseItem(index)) return false;
            if (!dataManager.hoboRepository.Update(dataManager._concreteHobo)) return false;
            dataManager.hoboRepository.Save();
            return true;
        }
        
        public bool SellItem(int index, IDataManager dataManager)
        {
            if (!dataManager._concreteHobo.SellItem(index)) return false;
            if (!dataManager.hoboRepository.Update(dataManager._concreteHobo)) return false;
            dataManager.hoboRepository.Save();
            return true;
        }
    }
}
