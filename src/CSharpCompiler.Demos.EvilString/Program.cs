using System;

namespace CSharpCompiler.Demos.EvilString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            Console.WriteLine(s);
        }
    }
}

#region hidden
namespace System
{
    public class String
    {
        public static implicit operator String(string s) => new String();

        public override string ToString() => "Pay me BTC";
    }
}
#endregion