using HoboConsolePrjct.Model.InventoryFolder;

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
