using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;


namespace HoboConsole.Model.Items
{
    public class Food : IItem, IEntity
    {
        public Guid Id { get; set; }
        public int Price { get; }
        public string Name { get; }
        public int Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        [JsonIgnore]
        public ItemTypeEnum ItemType { get; }
        public int Nutrition { get; } //Определяет энергетическую ценность еды
        public int EnergyBoost { get; }
        public int Healthy { get; } //Определяет насколько увеличится или уменьшится здоровье

        public int ItemTypeNum { get; set; }
        [JsonConstructor]
        public Food(Guid id, int price, string name, int pleasure, int ItemTypeNum, int nutrition, int energyBoost, int healthy)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            this.ItemTypeNum = ItemTypeNum;
            ItemType = (ItemTypeEnum)(this.ItemTypeNum);
            Nutrition = nutrition;
            EnergyBoost = energyBoost;
            Healthy = healthy;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeValueStatic.HealthChange(hobo, item);
            ChangeValueStatic.EnergyChange(hobo, item);
            ChangeValueStatic.EmotionalChange(hobo, item);
            ChangeValueStatic.SatiationChange(hobo, item);
        }
    }
}
