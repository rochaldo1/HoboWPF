using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel
{
    public class MainHoboVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string name = string.Empty;
        private int health;
        private int energy;
        private int satiation;
        private int emotionalState;

        public MainHoboVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Name = this.dataManager._concreteHobo.Name;
            Health = this.dataManager._concreteHobo.Health;
            Energy = this.dataManager._concreteHobo.Energy;
            Satiation = this.dataManager._concreteHobo.Satiation;
            EmotionalState = this.dataManager._concreteHobo.EmotionalState;
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        public int Health
        {
            get => health;
            set => Set(ref health, value);
        }
        public int Energy
        {
            get => energy;
            set => Set(ref energy, value);
        }
        public int Satiation
        {
            get => satiation;
            set => Set(ref satiation, value);
        }

        public int EmotionalState
        {
            get => emotionalState;
            set => Set(ref  emotionalState, value);
        }
    }
}
