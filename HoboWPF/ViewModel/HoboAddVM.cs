using HoboWPF.ViewModel.Commands;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HoboWPF.ViewModel
{
    public class HoboAddVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string name = string.Empty;

        public event Action? AddSucces;
        public event Action<string>? AddFailed;

        public HoboAddVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);   
        }

        private void AddHobo()
        {
            if (serviceManager.TryAddHobo(Name))
            {
                AddSucces?.Invoke();
            }
            else
            {
                AddFailed?.Invoke("Не удалось создать бомжа!");
            }
        }

        public ICommand AddHoboCommand
        {
            get
            {
                return new Command(() =>
                {
                    AddHobo();
                });
            }
        }
    }
}
