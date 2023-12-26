using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Model;
using HoboConsolePrjct.Model.Hobo;
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
    }
}
