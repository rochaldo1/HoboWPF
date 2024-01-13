using HoboConsolePrjct.Model.InventoryFolder;

namespace HoboConsolePrjct.Model.Places
{
    public interface IPlace : IEntity
    {
        public string Name { get; set; }
        public Inventory inventory { get; set; }
    }
}
