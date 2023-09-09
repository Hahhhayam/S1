using Core.Converters;
using Core.DTOs;
using Core.Entities;
using Core.Parsers.Program4you;

Map map = new Map();
using (Program4youParser parser = new("p4u"))
{
    parser.Read();
    map = parser.Parse();
}
map.Name = "IkuraDelivery";
map.Description = "Delivers your asian kitchen to your dinner!";
Console.Read();