using HoboConsolePrjct.Model.InventoryFolder;

namespace HoboConsolePrjct.Model.Places
{
    public class EstateEngency : IPlace
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Inventory inventory { get; set; }

        public EstateEngency(Guid Id, string Name, Inventory inventory) 
        {
            this.Id = Id;
            this.Name = Name;
            this.inventory = inventory;
        }
    }
}
