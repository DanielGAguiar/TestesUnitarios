using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCalc math = new TestCalc();
            math.SomarTest();
            math.SubtrairTest();
            math.MultiplicarTest();
            math.DividirTest();
            Console.ReadLine();
        }
    }
}
