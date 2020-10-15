using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaLib;

namespace AreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Area.AreaTriangulo(10, 20);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
