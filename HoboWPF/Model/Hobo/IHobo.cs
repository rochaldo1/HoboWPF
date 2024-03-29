﻿using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Places;

namespace HoboConsolePrjct.Model.Hobo
{
    public interface IHobo : IEntity
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Satiation { get; set; }
        public int EmotionalState { get; set; }
        public int Money { get; set; }
        public Inventory inventory { get; set; }
        public bool UseItem(int i);
        public bool BuyItem(IPlace place, int i);
        public bool SellItem(int i);
    }
}
