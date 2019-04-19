using System;
using System.Collections;
using System.Collections.Generic;

public class OrderInfo : MarshalByRefObject, IOrder_Info
{
    // Destination table : All the orders that were requested to that table
    Dictionary<int, List<Order>> ordersHistory = new Dictionary<int, List<Order>>();
    Dictionary<int, List<Order>> activeTables = new Dictionary<int, List<Order>>();

    public OrderInfo()
    {
        Console.WriteLine("Central Storage has been created.");
    }

    // --- Private Methods ---
    
    private bool CheckIfTableIsActive(int tableID)
    {
        return activeTables.ContainsKey(tableID);
    }

    private void WriteTableError(int tableID)
    {

        Console.WriteLine("The table with the ID " + tableID + " is not active.");
        Console.WriteLine("Operation not succeeded.");
    }

    public void OpenTable(int tableID)
    {
        if(activeTables.ContainsKey(tableID))
        {   
            Console.WriteLine("Table is already opened.");      //Send an error message to appear
            return;
        }
        List<Order> tableOrderList = new List<Order>();
        activeTables.Add(tableID, tableOrderList);
    }

    public void CloseTable(int tableID)
    {
        if(!activeTables.ContainsKey(tableID))
        {
            WriteTableError(tableID);
            return;
        }

        ordersHistory.Add(tableID, activeTables[tableID]);
        activeTables.Remove(tableID);
    }

    public void AddNewOrder(int tableID, Order newOrder)
    {
        if(!CheckIfTableIsActive(tableID))
        {
            WriteTableError(tableID);
            return;
        }

        activeTables[tableID].Add(newOrder);
    }

    public Order GetOrder(int tableID, int orderID)
    {
        if (!CheckIfTableIsActive(tableID))
        {
            WriteTableError(tableID);
            return null;
        }

        foreach(Order tableOrder in activeTables[tableID])
        {
            if (tableOrder.getID() == orderID)
                return tableOrder;
        }
        return null;
    }

    public List<Order> GetAllTableOrders(int tableID)
    {
        if (!activeTables.ContainsKey(tableID))
        {
            Console.WriteLine("The table with the ID " + tableID + " is not active.");
            Console.WriteLine("Operation not succeeded.");
            return null;
        }

        return activeTables[tableID];
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }
}
