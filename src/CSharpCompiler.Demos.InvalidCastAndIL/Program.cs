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
            StrangeOverloads();
            CastToAnything();
        }

        private static void StrangeOverloads()
        {
            // overloading by return type
            //Console.WriteLine(Hello.World());

            var intOverload = typeof(Hello).GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).First(m => m.Name == "World" && m.ReturnType == typeof(int));
            var stringOverload = typeof(Hello).GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).First(m => m.Name == "World" && m.ReturnType == typeof(string));
            Console.WriteLine(intOverload.Invoke(null, null));
            Console.WriteLine(stringOverload.Invoke(null, null));
        }

        private static void CastToAnything()
        {
            // cast to anything
            var human = new Human() { Name = "Filip" };
            human.SayHi();

            var oven = Screw.It<Oven>(human);
            oven.SayHi();
        }
    }

    public class Oven
    {
        public string Name { get; set; }

        public void SayHi() => Console.WriteLine($"I'm an oven {Name}");

        public void Bake() => Console.WriteLine("I'm baking");
    }

    public class Human
    {
        public string Name { get; set; }

        public void SayHi() => Console.WriteLine($"I'm a human {Name}");
        
        public void BeADouchebag() => Console.WriteLine("VOTE TRUMP");
    }
}
