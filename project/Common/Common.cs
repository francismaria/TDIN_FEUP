using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Order
{
    private int ID;
    private string description;
    private int destinationTable;
    private double price;
    private ORDER_STATE state;
    private ORDER_TYPE type;

    enum ORDER_STATE { NOT_PICKED, IN_PREPARATION, READY, PAID };
    
    enum ORDER_TYPE { KITCHEN, BAR }

    public Order()
    {
        ID = 0;
        description = null;
        destinationTable = 0;
        price = 15.0;
        state = 0;
    }

    public int getID()
    {
        return ID;
    }

    public int getDestinationTable()
    {
        return destinationTable;
    }
    public double getPrice()
    {
        return price;
    }
}

public interface IOrder_Info
{
    void AddNewOrder(Order newOrder);

    double GetPrice();

    Order GetOrder(int orderID);


}
