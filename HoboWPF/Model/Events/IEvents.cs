using HoboConsolePrjct.Model.InventoryFolder;

namespace HoboConsolePrjct.Model.Events
{
    public interface IEvents : IEntity
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Pleasure { get; set; }
        public int Healthy { get; set; }
        public int HealthyCheap { get; set; }
        public int EnergyBoost { get; set; }
        public int Nutrition { get; set; }
        public int Money { get; set; }
        public Inventory Inventory { get; set; }
    }
}
