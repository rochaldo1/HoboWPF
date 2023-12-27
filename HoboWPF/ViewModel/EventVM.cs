using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel
{
    public class EventVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public string text = string.Empty;
        private int health;
        private int energy;
        private int satiation;
        private int emotionalState;
        private int money;


        public EventVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Text = this.dataManager.ConcreteEvent.Text;
            Health = this.dataManager.ConcreteEvent.HealthyCheap;
            Energy = this.dataManager.ConcreteEvent.EnergyBoost;
            Satiation = this.dataManager.ConcreteEvent.Nutrition;
            EmotionalState = this.dataManager.ConcreteEvent.Pleasure;
            Money = this.dataManager.ConcreteEvent.Money;
        }

        public string Text
        {
            get => text;
            set => Set(ref text, value);
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
            set => Set(ref emotionalState, value);
        }

        public int Money
        {
            get => money;
            set => Set(ref money, value);
        }

    }
}
