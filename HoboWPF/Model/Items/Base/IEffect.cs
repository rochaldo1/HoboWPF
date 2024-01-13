using HoboConsolePrjct.Model.Hobo;
using HoboConsole.Model.Items.Base;

namespace HoboConsolePrjct.Model.Items.Base
{
    public interface IEffect
    {
        public void Effect(IHobo hobo, IItem item);
    }
}
