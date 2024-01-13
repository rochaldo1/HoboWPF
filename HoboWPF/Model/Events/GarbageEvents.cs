using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.InventoryEvents;
using HoboConsole.Model.Stacks;

namespace HoboConsolePrjct.Model.Event
{
    public class GarbageEvents : IEntity
    {
        public Guid Id { get; set; }
        public EventsList EventsList { get; set; }

        public GarbageEvents(Guid id, EventsList eventsList) 
        {
            Id = id;
            EventsList = eventsList;
        }

        public override string ToString()
        {
            return EventsList.ToString();
        }

        public void ApplyEffect(IHobo hobo, int whatEvent)
        {
            List<IEvents> list = EventsList.ShowEvent();
            List<IStack> stacks = list[whatEvent].Inventory.ShowInventory();
            if (stacks.Count != 0 || stacks != null) 
            {
                for (int i = 0; i < stacks.Count; i++)
                {
                    if (stacks[i].Count == 0 && (whatEvent == 0 || whatEvent == 1 || whatEvent == 2 || whatEvent == 3 ))
                    {
                        stacks[i].Count = 1;
                    }
                    hobo.inventory.AddStack(stacks[i]);
                }
            }
            hobo.Money += list[whatEvent].Money;
            ChangeValueStatic.HealthChange(hobo, list[whatEvent]);
            ChangeValueStatic.EnergyChange(hobo, list[whatEvent]);
            ChangeValueStatic.EmotionalChange(hobo, list[whatEvent]);
            ChangeValueStatic.SatiationChange(hobo, list[whatEvent]);
        }
    }
}
