using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HoboWPF.ViewModel.Commands;

namespace HoboWPF.ViewModel
{
    public class EndGameVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public event Action? DeleteSucces;
        public EndGameVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
        }

        public void DeleteHobo()
        {
            serviceManager.DeleteHobo();
            DeleteSucces?.Invoke();
        }
        public ICommand DeleteCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteHobo();
                });
            }
        }
    }
}
