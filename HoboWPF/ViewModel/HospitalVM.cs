using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Stacks;
using HoboWPF.ViewModel.Commands;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HoboWPF.ViewModel
{
    public class HospitalVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string name = string.Empty;
        private int money;
        private int index;
        private ObservableCollection<IItem> inventory = new ObservableCollection<IItem>();

        public event Action<string>? BuyFailed;
        public HospitalVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Name = dataManager.hospital.Name;
            Inventory = new ObservableCollection<IItem>(itemsShow());
            Money = dataManager._concreteHobo.Money;
        }
        private List<IItem> itemsShow()
        {
            List<IStack> stacks = dataManager.hospital.inventory.ShowInventory();
            List<IItem> items = new();
            for (int i = 0; i < stacks.Count; i++)
            {
                items.Add(stacks[i].Item);
            }
            return items;
        }
        private void Refresh()
        {
            Money = dataManager._concreteHobo.Money;
        }
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        public int Money
        {
            get => money;
            set => Set(ref money, value);
        }
        public ObservableCollection<IItem> Inventory
        {
            get => inventory;
            set => Set(ref inventory, value);
        }
        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }

        public void BuyItem()
        {
            if (serviceManager.TryBuyItem(dataManager.hospital, Index))
            {
                Refresh();
            }
            else
            {
                BuyFailed?.Invoke("Нет денег!");
            }
        }
        public ICommand BuyItemCommand
        {
            get
            {
                return new Command(() =>
                {
                    BuyItem();
                });
            }
        }

    }
}

