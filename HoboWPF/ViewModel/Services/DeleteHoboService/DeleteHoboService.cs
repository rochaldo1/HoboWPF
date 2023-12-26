using Newtonsoft.Json.Bson;
using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
