using System;
using System.Collections;
using System.Threading.Tasks;

namespace CSharpCompiler.Demos.Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await using (var disposableObject = new Foo())
            //{
            //    Console.WriteLine("Hello World!");
            //}

            //Console.WriteLine("Done!");
        }
    }

    //class Foo : IAsyncDisposable
    //{
    //    public async ValueTask DisposeAsync()
    //    {
    //        Console.WriteLine("Delaying!");
    //        await Task.Delay(1000);
    //        Console.WriteLine("Disposed!");
    //    }
    //}
}

//namespace System
//{
//    public interface IAsyncDisposable
//    {
//        ValueTask DisposeAsync();
//    }
//}
