using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Items.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Events
{
    public interface IEvents : IEntity
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Pleasure { get; set; }
        public int Healthy { get; set; }
        public int EnergyBoost { get; set; }
        public int Nutrition { get; set; }
        public int Money { get; set; }
        public Inventory Inventory { get; set; }
    }
}
