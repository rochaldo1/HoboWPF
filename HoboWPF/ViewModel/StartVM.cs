using HoboConsolePrjct.Model.Hobo;
using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel
{
    public class StartVM : BaseVM
    {
        IDataManager dataManager;
        private ObservableCollection<Hobo> hobos = new ObservableCollection<Hobo>();
        private int index;
        public StartVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
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
    }
}
