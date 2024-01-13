using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.Places;

namespace HoboWPF.ViewModel.Services
{
    public interface IServiceManager
    {
        public bool TryTakeHobo(Hobo hobo);
        public bool TryAlmsEvent();
        public bool TryGarbageEvent();
        public bool TryJobEvents();
        public void DeleteHobo();
        public bool TryAddHobo(string name);
        public bool TryUseItem(int index);
        public bool TrySellItem(int index);

        public bool TryBuyItem(IPlace place, int index);
    }
}
