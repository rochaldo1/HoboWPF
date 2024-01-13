using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.InventoryEvents;

namespace HoboConsolePrjct.Model.Events
{
    public class JobEvents : IEntity
    {
        public Guid Id { get; set; }

        public EventsList EventsList { get; set; }

        public JobEvents(Guid id, EventsList eventsList) 
        {
            Id = id;
            EventsList = eventsList;
        }

        public void ApplyEffect(IHobo hobo, int whatEvent)
        {
            List<IEvents> list = EventsList.ShowEvent();
            hobo.Money += list[whatEvent].Money;
            ChangeValueStatic.HealthChange(hobo, list[whatEvent]);
            ChangeValueStatic.EnergyChange(hobo, list[whatEvent]);
            ChangeValueStatic.EmotionalChange(hobo, list[whatEvent]);
            ChangeValueStatic.SatiationChange(hobo, list[whatEvent]);
        }
    }
}
