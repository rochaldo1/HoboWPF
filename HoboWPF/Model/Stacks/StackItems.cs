using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HoboConsole.Model.Stacks
{
    public class StackItems : IStack
    {
        public Guid Id { get; set; }
        public IItem Item { get; set; }
        public int Count { get; set; }

        [JsonConstructor]
        public StackItems(Guid Id, IItem item, int count)
        {
            this.Id = Id;
            Item = item;
            Count = count;
        }

    }
}
