using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.InventoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Events
{
    public class EventHobo : IEvents
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Pleasure { get; set; }
        public int Healthy { get; set; }
        public int EnergyBoost { get; set; }
        public int Nutrition { get; set; }
        public int Money { get; set; }
        public Inventory Inventory { get; set; }

        public EventHobo(Guid id, string text, int pleasure, int healthy, int energyBoost, int nutrition, int money, Inventory inventory)
        {
            Id = id;
            Text = text;
            Pleasure = pleasure;
            Healthy = healthy;
            EnergyBoost = energyBoost;
            Nutrition = nutrition;
            Money = money;
            Inventory = inventory;
        }

        public override string ToString()
        {
            return $"Text: {Text}\nPleasure: {Pleasure}\nHealthy: {Healthy}\nEnergyBoost: {EnergyBoost}\nNutrition: {Nutrition}\n\n";
        }
    }
}
