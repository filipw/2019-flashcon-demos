using SampleIL;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpCompiler.Demos.InvalidCastAndIL
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloading by return type
            //Console.WriteLine(Hello.World());

            var intOverload = typeof(Hello).GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).First(m => m.Name == "World" && m.ReturnType == typeof(int));
            var stringOverload = typeof(Hello).GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).First(m => m.Name == "World" && m.ReturnType == typeof(string));
            Console.WriteLine(intOverload.Invoke(null, null));
            Console.WriteLine(stringOverload.Invoke(null, null));

            // cast to anything
            var human = new Human() { Name = "Filip" };
            Console.WriteLine(human.Name);
            human.SayHi();

            var oven = Screw.It<Oven>(human);
            Console.WriteLine(oven.Name);
            oven.SayHi();
        }
    }

    public class Oven
    {
        public string Name { get; set; }

        public void SayHi()
        {
            Console.WriteLine($"I'm an oven {Name}");
        }
    }

    public class Human
    {
        public string Name { get; set; }

        public void SayHi()
        {
            Console.WriteLine($"I'm a human {Name}");
        }
    }
}
