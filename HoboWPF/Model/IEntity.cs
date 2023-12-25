using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
