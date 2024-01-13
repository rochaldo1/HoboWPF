using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model;


namespace HoboConsole.Model.Stacks
{
    public interface IStack : IEntity
    {
        public IItem Item { get; set; }
        public int Count { get; set; }
        public string ToString();
    }
}
