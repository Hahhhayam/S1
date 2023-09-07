using Core.Converters;
using Core.DTOs;
using Core.Entities;
using Core.Parsers.Program4you;

Map map = new Map();
map.Name = "IkuraDelivery";
map.Description = "Delivers your asian kitchen to your dinner!";
Program4youParser parser = new Program4youParser("graph");
Program4youDTO parsedGraph = parser.Graph;
Map map1 = Program4youGraphConverter.Convert(parsedGraph);
Console.Read();