using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Model;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace HoboConsole.Model.Items
{
    public class Garbage : IItem, IEntity
    {
        public Guid Id { get; set; }
        public int Price { get; }
        public string Name { get; }
        public int Pleasure { get; }
        public int Healthy { get; }
        [JsonIgnore]
        public ItemTypeEnum ItemType { get; }
        [JsonProperty ("ItemTypeNum")]
        public int ItemTypeNum { get; set; }
        [JsonConstructor]
        public Garbage(Guid id, int price, string name, int pleasure, int healthy, int ItemTypeNum)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            Healthy = healthy;
            this.ItemTypeNum = ItemTypeNum;
            ItemType = (ItemTypeEnum)this.ItemTypeNum;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeValueStatic.EmotionalChange(hobo, item);
            ChangeValueStatic.HealthChange(hobo, item);
        }

        public override string ToString()
        {
            return $"Name: {Name} Type: {ItemType} Price: {Price}";
        }
    }
}
