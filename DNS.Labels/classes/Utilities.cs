using System;
namespace DNS.Labels
{
    public static class Utilities
    {
        public static string NZString(object Data, string DefaultValue = "")
        {
            string ReturnValue = DefaultValue;
            if (Data != null) ReturnValue = Convert.ToString(Data);

            return ReturnValue;
        }
        public static int NZInt(object Data, int DefaultValue = 0)
        {
            int ReturnValue = DefaultValue;
            if (Data != null) ReturnValue = Convert.ToInt32(Data);

            return ReturnValue;
        }
    }
}
