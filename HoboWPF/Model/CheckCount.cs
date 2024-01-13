using HoboConsole.Model.Stacks;

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