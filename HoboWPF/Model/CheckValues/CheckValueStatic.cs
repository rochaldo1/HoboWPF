using HoboConsolePrjct.Model.Hobo;

namespace HoboConsolePrjct.Model.CheckValues
{
    public static class CheckValueStatic
    {
        public static int HealthCheck(IHobo hobo)
        {
            if (hobo.Health > 100)
                hobo.Health = 100;
            else if (hobo.Health < 0)
                hobo.Health = 0;
            return hobo.Health;
        }
        public static int EnergyCheck(IHobo hobo)
        {
            if (hobo.Energy > 100)
                hobo.Energy = 100;
            else if (hobo.Energy < 0)
                hobo.Energy = 0;
            return hobo.Energy;
        }
        public static int SatiationCheck(IHobo hobo)
        {
            if (hobo.Satiation > 100)
                hobo.Satiation = 100;
            else if (hobo.Satiation < 0)
                hobo.Satiation = 0;
            return hobo.Satiation;
        }
        public static int EmotionalCheck(IHobo hobo)
        {
            if (hobo.EmotionalState > 100)
                hobo.EmotionalState = 100;
            else if (hobo.EmotionalState < 0)
                hobo.EmotionalState = 0;
            return hobo.EmotionalState;
        }
    }
}
