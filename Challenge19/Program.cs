using System;

namespace Sorter
{
    public class Program18
    {
        public static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] number = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
        }
        public static int Sort(int[] number)
        {
            Array.Sort(number);
			foreach(int p in number)
				Console.Write("{0}  ", p);
                return ("{0}  ", p);
        }
    }
}
