using HoboConsole.Model.Stacks;

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
