using HoboWPF.ViewModel.DataManager;

namespace HoboWPF.ViewModel.Services.DeleteHoboService
{
    public class DeleteHoboService : IDeleteHoboService
    {
        public DeleteHoboService() { }
        public static DeleteHoboService Instance() => new();
        public void DeleteHobo(IDataManager dataManager)
        {
            dataManager.hoboRepository.Delete(dataManager._concreteHobo);
            dataManager.hoboRepository.Save();
        }
    }
}
