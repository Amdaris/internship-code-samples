using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Node : IVisitable
    {
        public abstract  void Accept(IVisitor visitor);
    }
}
