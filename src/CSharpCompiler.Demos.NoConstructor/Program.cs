using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace CSharpCompiler.Demos.NoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Minnie");
            dog.Bark();

            Console.ReadLine();
        }

        #region weird
        static Dog CreateWeirdDog()
        {
            return (Dog)RuntimeHelpers.GetUninitializedObject(typeof(Dog));
        }
        #endregion

    }

    class Dog
    {
        private string _name;

        public Dog(string name)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Bark()
        {
            Console.WriteLine($"Woof woof! {_name} barks!");
        }
    }
}
