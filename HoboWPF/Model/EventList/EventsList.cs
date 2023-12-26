using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.InventoryEvents
{
    public class EventsList : IEventsList
    {
        public Guid Id { get; set; }
        [JsonProperty]
        private List<IEvents> events = new();

        [JsonConstructor]
        public EventsList(List<IEvents> events)
        {
            this.events = events;
        }
        public EventsList()
        {

        }
        public void AddEvent(IEvents item)
        {
            events.Add(item);
        }

        public void DeleteEvent(int i)
        {
            events.RemoveAt(i);
        }
        public IEvents GetEvent(int number)
        {
            return events[number];
        }
        public List<IEvents> ShowEvent()
        {
            return events;
        }

        public void UpdateEvents(List<IEvents> events)
        {
            this.events = events;
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (var i = 0; i < events.Count; i++)
            {
                s += events[i].ToString();
            }
            return "Event: " + s;
        }
    }
}
