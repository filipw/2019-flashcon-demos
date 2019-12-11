using System;
using System.Runtime.InteropServices;

namespace CSharpCompiler.Demos.StructLayout
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Minnie");
            dog.Bark();

            ChangeDogName(dog);

            dog.Bark();
        }

        private static void ChangeDogName(Dog dog)
        {
            var hack = new Hack
            {
                Dog = dog
            };
            hack.HackedDog._name = "Mickey";
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

    [StructLayout(LayoutKind.Explicit)]
    public class Hack
    {
        [FieldOffset(0)]
        public Dog Dog;

        [FieldOffset(0)]
        public HackedDog HackedDog;
    }

    public class HackedDog
    {
        public string _name;
    }
}
