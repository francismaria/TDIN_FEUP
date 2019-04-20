using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// -- Order Object --

[Serializable]
public class Order
{
    private static int IDCounter = 0;
    private static object locker = new object();

    private int ID;
    private string description;
    private int destinationTable;
    private double price;
    private ORDER_STATE state;
    private ORDER_TYPE type;

    public enum ORDER_STATE { NOT_PICKED, IN_PREPARATION, READY, PAID };
    
    public enum ORDER_TYPE { KITCHEN, BAR }

    public Order()
    {
        ID = 0;
        description = "";
        destinationTable = 0;
        price = 0.0;
        state = ORDER_STATE.NOT_PICKED;
    }

    public Order(string description, int destinationTable, double price, ORDER_TYPE type)
    {
        lock(locker)
        {
            IDCounter++;
            ID = IDCounter;
        }
        this.description = description;
        this.destinationTable = destinationTable;
        this.price = price;
        state = ORDER_STATE.NOT_PICKED;
        this.type = type;
    }

    public int getID()
    {
        return ID;
    }

    public string getDescription()
    {
        return description;
    }

    public int getDestinationTable()
    {
        return destinationTable;
    }
    public double getPrice()
    {
        return price;
    }

    public ORDER_STATE getState()
    {
        return state;
    }

    public ORDER_TYPE getType()
    {
        return type;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || obj.GetType() != typeof(Order))
            return false;

        return ID == ((Order)obj).getID();
    }
}

public class UpdateActiveTablesRepeater : MarshalByRefObject
{
    public event UpdateActiveTablesDelegate updateActiveTablesEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(List<int> activeTablesIDs)
    {
        if (updateActiveTablesEvent != null)
            updateActiveTablesEvent(activeTablesIDs);
    }
}

// -- Common Interface --

public interface IOrder_Info
{
    event UpdateActiveTablesDelegate updateActiveTablesEvent;

    void OpenTable(int tableID);

    void CloseTable(int tableID);

    void AddNewOrder(int tableID, Order newOrder);

    List<Order> GetAllTableOrders(int tableID);
    
    Order GetOrder(int tableID, int orderID);


}

// -- Events -- 

public delegate void UpdateActiveTablesDelegate(List<int> activeTablesIDs);