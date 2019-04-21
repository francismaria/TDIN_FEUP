using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Meal
{

    private static int IDCounter = 0;
    private static object locker = new object();

    private int ID;
    private int tableID;
    private DateTime start;
    private DateTime? end;
    private List<Order> orders;
    private double totalPrice;

    public Meal(int tableID)
    {
        lock (locker)
        {
            IDCounter++;
            ID = IDCounter;
        }
        this.tableID = tableID;
        start = DateTime.Now;
        end = null;
        orders = new List<Order>();
        totalPrice = 0;
    }

    public int getID()
    {
        return ID;
    }

    public int getTableID()
    {
        return tableID;
    }

    public DateTime getStartTime()
    {
        return start;
    }

    public DateTime getEndTime()
    {
        if(end.HasValue)
        {
            return end.Value;
        }
        return end.GetValueOrDefault();
    }

    public Order getOrder(int orderID)
    {
        foreach(Order order in orders)
        {
            if (order.getID() == orderID)
                return order;
        }
        return null;
    }

    public List<Order> getAllOrders()
    {
        return orders;
    }

    public double getTotalPrice()
    {
        return totalPrice;
    }

    public void addOrder(Order order)
    {
        orders.Add(order);
        totalPrice += order.getPrice();
    }
}

