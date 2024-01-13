using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model;
using Newtonsoft.Json;

namespace HoboConsole.Model.Items
{
    public class RealEstate : IItem, IEntity
    {
        public Guid Id { get; set; }
        public int Price { get; }
        public string Name { get; }
        public int Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        [JsonIgnore]
        public ItemTypeEnum ItemType { get; }

        public int ItemTypeNum { get; set; }
        [JsonConstructor]
        public RealEstate(Guid id, int price, string name, int pleasure, int ItemTypeNum)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            this.ItemTypeNum = ItemTypeNum;
            ItemType = (ItemTypeEnum)this.ItemTypeNum;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeValueStatic.EmotionalChange(hobo, item);
        }
    }
}
