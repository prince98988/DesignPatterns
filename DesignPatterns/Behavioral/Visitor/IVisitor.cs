using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor 
    {
        public int getRadius(Circle circle);
        public int getHeight(Ractangle ractangle);
    }
}
