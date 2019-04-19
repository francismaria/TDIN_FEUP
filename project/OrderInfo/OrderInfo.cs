using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    private int ID;
    private string description;
    private int destinationTable;
    private double price;
    private int state;

    public Order()
    {
        ID = 0;
        description = null;
        destinationTable = 0;
        price = 0.0;
        state = 0;
    }
}

public class OrderInfo : MarshalByRefObject, IOrder_Info
{
    ArrayList ordersList;

    public OrderInfo()
    {
        Console.WriteLine("Database has been created.");
    }

    public void AddNewOrder()
    {
        Order order = new Order();
        ordersList.Add(order);
        Console.WriteLine("ADDED has been created.");
    }

    public double GetPrice()
    {
        return 14.0;
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }
}
