using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
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
