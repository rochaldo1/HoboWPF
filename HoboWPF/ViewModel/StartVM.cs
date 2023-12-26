using HoboConsolePrjct.Model.Hobo;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HoboWPF.ViewModel.Commands;

namespace HoboWPF.ViewModel
{
    public class StartVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private ObservableCollection<Hobo> hobos = new ObservableCollection<Hobo>();
        private int index;

        public event Action? TakeHoboSucces;
        public event Action<string>? TakeHoboFailed;
        public StartVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Hobos = new ObservableCollection<Hobo>(dataManager.hoboRepository.GetHobos());
            Index = 0;
        }

        public ObservableCollection<Hobo> Hobos
        {
            get => hobos;
            set => Set(ref hobos, value);
        }
        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }

        public void TakeHobo()
        {
            if (serviceManager.TryTakeHobo(Hobos[Index]))
            {
                TakeHoboSucces?.Invoke();
            }
            else
            {
                TakeHoboFailed?.Invoke("Не удалось взять бомжа!");
            }
        }

        public ICommand TakeHoboCommand
        {
            get
            {
                return new Command(() =>
                {
                    TakeHobo();
                });
            }
        }

        public void Refresh()
        {
            Hobos = new ObservableCollection<Hobo>(dataManager.hoboRepository.GetHobos());
        }
    }
}
