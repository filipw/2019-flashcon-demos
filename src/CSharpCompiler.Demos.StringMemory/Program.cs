using System;
using System.Runtime.InteropServices;

namespace CSharpCompiler.Demos.StringMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            //// unsafe write
            var text = "Minnie";
            Console.WriteLine(text);
            Console.ReadLine();

            var span = MemoryMarshal.AsMemory(text.AsMemory()).Span;
            var hacked = new char[] { 'h', 'a', 'c', 'k', 'e', 'd' };
            for (var i = 0; i < hacked.Length; i++)
            {
                span[i] = hacked[i];
            }

            Console.WriteLine(text);
            Console.ReadLine();

            var minnie = new Dog("Minnie");
            minnie.Bark();
        }
    }

    public class Dog
    {
        private string _name;

        public Dog(string name)
        {
            _name = name;
        }

        public void Bark()
        {
            Console.WriteLine($"woof, I'm {_name}");
        }
    }
}
