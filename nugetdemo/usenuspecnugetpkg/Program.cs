using System;
using mynuspecnugetpkg;

namespace usenuspecnugetpkg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(new DemoPackageNuspec().HelloWorldNugetDemo());
            Console.ReadLine();
        }
    }
}
