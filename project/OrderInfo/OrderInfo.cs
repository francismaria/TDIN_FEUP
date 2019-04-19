using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderInfo : MarshalByRefObject, IOrder_Info
{
    ArrayList ordersList;

    public OrderInfo()
    {
        ordersList = new ArrayList();
        Console.WriteLine("Database has been created.");
    }

    public void AddNewOrder(Order newOrder)
    {
        ordersList.Add(newOrder);
        Console.WriteLine("ADDED has been created.");
    }

    public double GetPrice()
    {
        return 14.0;
    }

    public Order GetOrder(int orderID)
    {
        foreach(Order order in ordersList)
        {
            if(order.getID() == orderID)
            {
                return order;
            }
        }
        return null;
    }


    public override object InitializeLifetimeService()
    {
        return null;
    }
}
