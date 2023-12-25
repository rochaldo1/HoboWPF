using HoboConsolePrjct.Model.InventoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Places
{
    public class Hospital : IPlace
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Inventory inventory { get; set; }

        public Hospital(Guid Id, string Name, Inventory inventory)
        {
            this.Id = Id;
            this.Name = Name;
            this.inventory = inventory;
        }
    }
}
