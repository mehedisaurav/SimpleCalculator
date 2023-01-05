using MathS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.AdditionalMethods
{
    public static class Area
    {

        public static void Display(this SimpleMath math, int val1, int val2)
        {
            Console.WriteLine("Extended method called...");

            Console.WriteLine(math.Multiple(val1, val2));
        }

        public static void Addition(this SimpleMath math)
        {
            Console.WriteLine("Addition called...");
        }
    }
}
