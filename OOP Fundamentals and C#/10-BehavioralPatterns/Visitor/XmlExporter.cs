using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class XmlExporter : IVisitor
    {
        public void Visit(City city)
        {
            Console.WriteLine($"Exporting {city.Name} (city) to XML");
        }

        public void Visit(Monument monument)
        {
            Console.WriteLine($"Exporting {monument.MonumentName} (monument) to XML");
        }
    }
}
