using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NugetDemo;

namespace UseNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Class1 ndemo = new Class1();
            int c = ndemo.add(a, b);
            Console.WriteLine(c);
            Console.WriteLine(ndemo.subtract(a,b));
            Console.ReadLine();

        }
    }
}
