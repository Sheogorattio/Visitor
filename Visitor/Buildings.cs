using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface Building
    {
        void accept(Visitor visitor);
    }
    public class House : Building
    {
        public void accept(Visitor visitor)
        {
            visitor.VisitHouse(this);
        }
    }
    public class Factory : Building
    {
        public void accept(Visitor visitor)
        {
            visitor.VisitFactory(this);
        }
    }
    public class Bank : Building
    {
        public void accept(Visitor visitor)
        {
            visitor.VisitBank(this);
        }
    }
}
