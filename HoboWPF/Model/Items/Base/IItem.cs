using HoboConsolePrjct.Model;
using HoboConsolePrjct.Model.Items.Base;

namespace HoboConsole.Model.Items.Base
{
    public interface IItem : IEntity, IEffect
    {
        public int ItemTypeNum { get; set; }
        public int Price { get; }
        public string Name { get; }
        public int Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public ItemTypeEnum ItemType { get; }
        public  string ToString();
    }
}
