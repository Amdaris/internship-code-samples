
using Visitor;

var nodes = new List<IVisitable>
{
    new City {Name = "Timisoara"},
    new Monument {MonumentName = "Catedrala Mitropolitana"},
    new Monument { MonumentName = "Muzeul Revolutiei" },
    new City { Name = "Seattle"},
    new Monument { MonumentName = "Space Needle"},
    new Monument { MonumentName = "Century Link Field"}
};

var xmlExporter = new XmlExporter();

nodes.ForEach(node => node.Accept(xmlExporter));

Console.ReadLine();
