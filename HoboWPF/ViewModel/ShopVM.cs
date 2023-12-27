using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Places;
using HoboWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Stacks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace HoboWPF.ViewModel
{
    class ShopVM : BaseVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string name = string.Empty;
        private int money;
        private int index;
        private ObservableCollection<IItem> inventory = new ObservableCollection<IItem>();
        public ShopVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Name = dataManager.Stores.Name;
            Inventory = new ObservableCollection<IItem>(itemsShow());
            Money = dataManager._concreteHobo.Money;
        }
        private List<IItem> itemsShow()
        {
            List<IStack> stacks = dataManager.Stores.inventory.ShowInventory();
            List<IItem> items = new();
            for (int i = 0; i< stacks.Count; i++)
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
            if (serviceManager.TryBuyItem(dataManager.StoreRepository.GetStores(), Index))
            {
                Refresh();
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
