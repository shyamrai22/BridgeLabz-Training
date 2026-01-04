using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Base class
    class Order
    {
        public int OrderId;
        public DateTime OrderDate;

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        // Virtual method
        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }

    // Subclass lvl-1
    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }

    // Subclass lvl-2
    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate;

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }
    }

    // Caller
    class Caller
    {
        public static void Main(string[] args)
        {
            Order order1 = new Order(101, DateTime.Now);
            Order order2 = new ShippedOrder(102, DateTime.Now.AddDays(-2), "12345");
            Order order3 = new DeliveredOrder(103, DateTime.Now.AddDays(-5), "67890", DateTime.Now);
            Console.WriteLine($"Order 101 Status --> {order1.GetOrderStatus()}");
            Console.WriteLine($"Order 102 Status --> {order2.GetOrderStatus()}");
            Console.WriteLine($"Order 103 Status --> {order3.GetOrderStatus()}");
        }
    }
}
