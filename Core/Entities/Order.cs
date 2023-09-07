namespace Core.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public MapPoint Point { get; set; }
        public DateTimeOffset Time { get; set; } = DateTimeOffset.Now;
        public User User { get; set; }

        public Order(MapPoint point, DateTimeOffset time, User user)
        {
            Point = point;
            Time = time;
            User = user;
            Created(this);
        }

        public delegate void OrderEvent(Order order);
        private event OrderEvent Created = (o) =>
        {
            o.Point_Update(o);
            o.User_Update(o);
        };

        void Point_Update(Order order)
        {
            order.Point.Orders.Add(order);
        }
        void User_Update(Order order)
        {
            order.User.Orders.Add(order);
        }
    }
}
