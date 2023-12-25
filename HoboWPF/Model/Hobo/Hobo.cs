using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Places;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Hobo
{
    public class Hobo : IHobo
    {
        public Guid Id { get; set; }
        public string Name { get; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Satiation { get; set; }
        public int EmotionalState { get; set; }
        public int Money { get; set; }
        public Inventory inventory {  get; set; }

        public Hobo(Guid id ,string name, int health, int energy, int satiation, int emotionalState, int money, Inventory inventory)
        {
            Id = id;
            Name = name;
            Health = health;
            Energy = energy;
            Satiation = satiation;
            EmotionalState = emotionalState;
            Money = money;
            this.inventory = inventory;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nЗдоровье: {Health}\nЭнергия: {Energy}\nНАСЫЩЕНИЕ: {Satiation}\nЭМОТИОНАЛ ДАМАГЕ:{EmotionalState}\nДеньги: {Money}\n" + inventory.ToString();
        }
        public bool UseItem(IHobo hobo, int i)
        {
            List<IStack> hoboInventory = inventory.ShowInventory() ;
            if (hoboInventory.Count == 0 || (i > hoboInventory.Count - 1)) return false;
            if (CheckCount.Check(hoboInventory[i]))
            {
                hoboInventory[i].Item.Effect(hobo, hoboInventory[i].Item);
                hoboInventory[i].Count--;
                if (CheckCount.Check(hoboInventory[i]))
                {
                    inventory.UpdateInventory(hoboInventory);
                    return true;
                }
                inventory.DeleteItem(i);
                return true;
            }
            return false;
        }

        public bool BuyItem(IPlace place, int i)
        {
            List<IStack> placeInventory = place.inventory.ShowInventory();
            if (placeInventory.Count == 0 || (i > placeInventory.Count - 1)) return false;
            if (CheckCount.Check(placeInventory[i]))
            {
                if (Money >= placeInventory[i].Item.Price)
                {
                    Money -= placeInventory[i].Item.Price;
                    inventory.AddStack(placeInventory[i]);
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool SellItem(int i)
        {
            List<IStack> hoboInventory = inventory.ShowInventory();
            if (hoboInventory.Count == 0 || (i > hoboInventory.Count - 1)) return false;
            if (CheckCount.Check(hoboInventory[i]))
            {
                Money += hoboInventory[i].Item.Price;
                hoboInventory[i].Count--;
                if (CheckCount.Check(hoboInventory[i]))
                {
                    inventory.UpdateInventory(hoboInventory);
                    return true;
                }
                inventory.DeleteItem(i);
                return true;
            }
            return false;
        }
    }
}
