using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (float i = -3; i < Math.PI ; i += 0.3F)
            {
                Console.WriteLine("The sine of {0,10:F} = {1,-10:F6}" + spaces(Math.Pow(i, 2)) + "*", i, Math.Pow(i, 2));
            }
        }
        private static string spaces(double val)
        {
            string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
            return SpaceString;
        }
    }
}
