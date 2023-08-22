using Core.MapObj.Converters;
using Core.MapObj.Entities;
using Core.MapObj.Parsers.Program4you;

Map map = new Map();
map.Name = "IkuraDelivery";
map.Description = "Delivers your asian kitchen to your dinner!";
Program4youParser parser = new Program4youParser("graph");
Program4youGraph parsedGraph = parser.Graph;
Map map1 = Program4youGraphConverter.Convert(parsedGraph);
Console.Read();