using System.Diagnostics;

namespace Core.Entities
{
    internal class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
