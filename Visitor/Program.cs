using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building[] Buildings = {new House(), new Bank(), new Factory()};
            Visitor visitor = new Visitor();
            foreach (Building b in Buildings)
            {
                b.accept(visitor);
            }
            Console.ReadKey();
        }
    }
}
