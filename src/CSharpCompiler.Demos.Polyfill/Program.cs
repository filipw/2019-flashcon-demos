using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompiler.Demos.Polyfill
{
    class Program
    {
        static void Main(string[] args)
        {
            var housePrice = 900340.346;
            var message1 = $"Price of house is {housePrice}CHF.";
            Console.WriteLine(message1);

            IFormattable message2 = $"Price of house is {housePrice:N3}CHF.";
            Console.WriteLine(message2);

            Console.ReadLine();
        }
    }
}
