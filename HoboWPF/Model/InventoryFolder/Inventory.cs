using HoboConsole.Model.Stacks;
using Newtonsoft.Json;

namespace HoboConsolePrjct.Model.InventoryFolder
{
    public class Inventory : IInventory
    {
        [JsonProperty]
        private List<IStack> stacks = new();
        [JsonConstructor]
        public Inventory(List<IStack> stacks)
        {
            this.stacks = stacks;
        }
        public Inventory()
        {
        
        }

        public void AddStack(IStack item)
        {
            var p = from stacked in stacks
                    where stacked.Item.Name == item.Item.Name
                    select stacked;
            if (p.Count() != 0)
            {
                for(int i = 0; i < stacks.Count; i++)
                {
                    if (stacks[i].Item.Name == item.Item.Name)
                    {
                        stacks[i].Count++;
                        return;
                    }
                }
            }
            stacks.Add(item);
        }

        public void DeleteItem(int i)
        {
            stacks.RemoveAt(i);
        }

        public List<IStack> ShowInventory()
        {
            return stacks;
        }

        public void UpdateInventory(List<IStack> stacks)
        {
            this.stacks = stacks;
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (var i = 0; i < stacks.Count; i++)
            {
                s += stacks[i].Item.Name.ToString();
                s += " " + stacks[i].Count.ToString() + " ";
            }
            return "Inventory: " + s;
        }

    }
}
