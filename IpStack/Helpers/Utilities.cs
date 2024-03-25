namespace IpStack.Helpers
{
    public static class Utilities
    {
        public static int? BoolToInt(bool? value)
        {
            if (value == true)
            {
                return 1;
            }
            else if (value == false)
            {
                return 0;
            }
            else
            {
                return null;
            }
        }
    }
}
