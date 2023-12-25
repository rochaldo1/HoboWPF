using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Model.Hobo;

namespace HoboConsolePrjct.Model.InventoryFolder
{
    public interface IInventory
    {
        public void AddStack(IStack item);
        public List<IStack> ShowInventory();
        public void DeleteItem(int i);
        public void UpdateInventory(List<IStack> stacks);
    }
}
