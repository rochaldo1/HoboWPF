using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HoboWPF.ViewModel.Commands;
using System.Printing;
using System.Collections.ObjectModel;
using HoboConsole.Model.Stacks;
using HoboConsole.Model.Items.Base;

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
        private int money;
        private ObservableCollection<IStack> stacks;
        private int index;
        private string nameItem;
        private string typeItem;
        

        public event Action? EventSucces;
        public event Action<string>? EventFailed;
        public event Action<string>? UseItemEventFailed;


        public MainHoboVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Name = this.dataManager._concreteHobo.Name;
            Health = this.dataManager._concreteHobo.Health;
            Energy = this.dataManager._concreteHobo.Energy;
            Satiation = this.dataManager._concreteHobo.Satiation;
            EmotionalState = this.dataManager._concreteHobo.EmotionalState;
            Money = this.dataManager._concreteHobo.Money;
            Stacks = new ObservableCollection<IStack>(this.dataManager._concreteHobo.inventory.ShowInventory());
            
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
            set => Set(ref emotionalState, value);
        }

        public int Money
        {
            get => money;
            set => Set(ref money, value);
        }

        public ObservableCollection<IStack> Stacks
        {
            get => stacks;
            set => Set(ref stacks, value);
        }

        public int Index
        {
            get => index;
            set
            {
                if (value == -1)
                    Set(ref index, 0);
                else Set(ref index, value);
                NameItem = Stacks[Index].Item.ToString();
                TypeItem = Stacks[Index].Item.ItemType.ToString();
            }
        }

        public string NameItem
        {
            get => nameItem;
            set => Set(ref nameItem, value);
        }
        public string TypeItem
        {
            get => typeItem;
            set=> Set(ref typeItem, value);
        }

        private void AlmsEvent()
        {
            if (serviceManager.TryAlmsEvent())
            {
                EventSucces?.Invoke();
                Refresh();
            }
            else
            {
                serviceManager.DeleteHobo();
                EventFailed?.Invoke("Ваш бомжик умер(((((( Игра закончена!");
                
            }
        }

        private void GarbageEvent()
        {
            if (serviceManager.TryGarbageEvent())
            {
                EventSucces?.Invoke();
                Refresh();
            }
            else
            {
                serviceManager.DeleteHobo();
                EventFailed?.Invoke("Ваш бомжик умер(((((( Игра закончена!");

            }
        }

        private void JobEvent()
        {
            if (serviceManager.TryJobEvents())
            {
                EventSucces?.Invoke();
                Refresh();
            }
            else
            {
                serviceManager.DeleteHobo();
                EventFailed?.Invoke("Ваш бомжик умер(((((( Игра закончена!");

            }
        }

        private void UseItem()
        {
            if(serviceManager.TryUseItem(Index))
            {
                Refresh();
            }
            else
            {
                Refresh();
                UseItemEventFailed?.Invoke("Инвентарь пуст!!!");
            }
        }
        private void SellItem()
        {
            if (serviceManager.TrySellItem(Index))
            {
                Refresh();
            }
            else
            {
                Refresh();
                UseItemEventFailed?.Invoke("Нечего продать!");
            }
        }

        public ICommand UseItemCommand
        {
            get
            {
                return new Command(() =>
                {
                    UseItem();
                });
            }
        }

        public ICommand SellItemCommand
        {
            get
            {
                return new Command(() =>
                {
                    SellItem();
                });
            }
        }
        public ICommand JobEventCommand
        {
            get
            {
                return new Command(() =>
                {
                    JobEvent();
                });
            }
        }
        public ICommand GarbageEventCommand
        {
            get
            {
                return new Command(() =>
                {
                    GarbageEvent();
                });
            }
        }

        public ICommand AlmsEventCommand
        {
            get
            {
                return new Command(() =>
                {
                    AlmsEvent();
                });
            }
        }

        public void Refresh()
        {
            Name = dataManager._concreteHobo.Name;
            Health = dataManager._concreteHobo.Health;
            Energy = dataManager._concreteHobo.Energy;
            Satiation = dataManager._concreteHobo.Satiation;
            EmotionalState = dataManager._concreteHobo.EmotionalState;
            Money = dataManager._concreteHobo.Money;
            Stacks = new ObservableCollection<IStack>(this.dataManager._concreteHobo.inventory.ShowInventory());
        }
    }
}
