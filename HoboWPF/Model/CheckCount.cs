using HoboConsole.Model.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model
{
    public static class CheckCount
    {
        public static bool Check(IStack stack)
        {
            if (stack.Count <= 0) return false;
            return true;
        }
    }
}