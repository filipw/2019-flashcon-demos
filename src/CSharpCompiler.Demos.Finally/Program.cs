using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace CSharpCompiler.Demos.Finally
{
    public class AzureResourceProvider : IDisposable
    {
        public void ProvisionAzureResourcesForALotOfMoney()
        {
            Console.WriteLine("Provisioned resources costing 10 000$ per minute.");
        }

        public void Dispose()
        {
            Console.WriteLine("Deprovisioned Azure resources. Saved you money.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var azureResourceProvider = new AzureResourceProvider())
            {
                DoStuff();
            }
        }

        static void DoStuff()
        {
            throw new Exception("Do Stuff failed");
        }

        static void DoStuffEvil()
        {
            Environment.FailFast(null);
        }
    }
}
