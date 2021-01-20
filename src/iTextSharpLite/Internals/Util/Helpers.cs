using System.Globalization;

namespace Internals.Util
{
    /// <summary>
    /// Summary description for Util.
    /// </summary>
    public class Helpers
    {
        public static int USR(int op1, int op2)
        {
            if (op2 < 1)
            {
                return op1;
            }
            else
            {
                return unchecked((int)((uint)op1 >> op2));
            }
        }

        public static bool EqualsIgnoreCase(string s1, string s2)
        {
            return CultureInfo.InvariantCulture.CompareInfo.Compare(s1, s2, CompareOptions.IgnoreCase) == 0;
        }

        public static int CompareToIgnoreCase(string s1, string s2)
        {
            return CultureInfo.InvariantCulture.CompareInfo.Compare(s1, s2, CompareOptions.IgnoreCase);
        }
    }
}