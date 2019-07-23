using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Build.Evaluation;

namespace ManagedLibrary
{
    // Sample managed code for the host to call
    public class ManagedWorker
    {
        // This assembly is being built as an exe as a simple way to
        // get .NET Core runtime libraries deployed (`dotnet publish` will
        // publish .NET Core libraries for exes). Therefore, this assembly
        // requires an entry point method even though it is unused.
        public static void Main()
        {
            Console.WriteLine("This assembly is not meant to be run directly.");
            Console.WriteLine("Instead, please use the SampleHost process to load this assembly.");
        }

        public delegate int ReportProgressFunction(int progress);

        // This method is invoked by unmanaged code.
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static string DoWork(
            [MarshalAs(UnmanagedType.LPStr)] string jobName,
            int iterations,
            int dataSize,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] double[] data,
            ReportProgressFunction reportProgressFunction)
        {
            // Uncomment line below to take time for debugger attach.
            // Thread.Sleep(15000);

            try
            {
                ProjectCollection projectCollection = new ProjectCollection();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "Success";
        }
    }
}
