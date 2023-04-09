using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Visitor
    {
       public void VisitBank(Bank obj)
        {
            Console.WriteLine("Let`s take out robbery insurance.");
        }
        public void VisitFactory(Factory obj)
        {
            Console.WriteLine("Let`s take out fire insurance.");
        }
        public void VisitHouse(House obj)
        {
            Console.WriteLine("Let`s take out health onsurance");
        }
    }
}
