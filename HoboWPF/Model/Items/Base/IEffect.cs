using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Model;
using HoboConsolePrjct.Model.Hobo;
using HoboConsole.Model.Items.Base;

namespace HoboConsolePrjct.Model.Items.Base
{
    public interface IEffect
    {
        public void Effect(IHobo hobo, IItem item);
    }
}
