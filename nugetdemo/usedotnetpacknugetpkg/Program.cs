using System;
using mydotnetpacknugetpkg;

namespace usedotnetpacknugetpkg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(new DemoPackageDotnetPack().HelloWorldNugetDemo());
            Console.ReadLine();
        }
    }
}
