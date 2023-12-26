using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.InventoryEvents;

namespace HoboConsolePrjct.Model
{
    public static class GetCount
    {
        public static int GetCountOf(IEntity entity)
        {
            if (entity is EventsList list)
            {
                List<IEvents> list2 = list.ShowEvent();
                return list2.Count;
            }
            return 0;
        }
    }
}