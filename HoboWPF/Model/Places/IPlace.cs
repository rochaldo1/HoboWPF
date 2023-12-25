using HoboConsolePrjct.Model.InventoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Places
{
    public interface IPlace : IEntity
    {
        public string Name { get; set; }
        public Inventory inventory { get; set; }
    }
}
