using System.Diagnostics;

namespace Core.Entities
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
