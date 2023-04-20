namespace ServicesPatternsSolid
{
    public interface IOrderService
    {
        Order CreateOrder(OrderDetails details);
        bool UpdateOrderStatus(int orderId, OrderStatus status);
        decimal CalculateOrderTotal(int orderId);
    }

    public class OrderService : IOrderService
    {
        public Order CreateOrder(OrderDetails details)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateOrderTotal(int orderId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrderStatus(int orderId, OrderStatus status)
        {
            throw new NotImplementedException();
        }
    }

    public class Order
    {

    }

    public class OrderDetails
    {
    }

    public enum OrderStatus
    {
        None = 0,
        Pending = 1,
        Shipped = 2,
        Delivered = 3
    }
}