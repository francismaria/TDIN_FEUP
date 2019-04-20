using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class OrderInfo : MarshalByRefObject, IOrder_Info
{
    // Destination table ID : All the orders that were requested to that table
    Dictionary<int, List<Order>> ordersHistory = new Dictionary<int, List<Order>>();
    Dictionary<int, List<Order>> activeTables = new Dictionary<int, List<Order>>();

    // -- Events -- 

    public event UpdateActiveTablesDelegate updateActiveTablesEvent;

    public OrderInfo()
    {
        Console.WriteLine("Central Storage has been created.");
    }

    // --- Private Methods ---
    
    private bool IsTableActive(int tableID)
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
        if(IsTableActive(tableID))
        {   
            Console.WriteLine("Table is already opened.");      //Send an error message to appear
            return;
        }
        List<Order> tableOrderList = new List<Order>();
        activeTables.Add(tableID, tableOrderList);
        UpdateActiveTables();
    }

    public void CloseTable(int tableID)
    {
        if(!IsTableActive(tableID))
        {
            WriteTableError(tableID);
            return;
        }

        ordersHistory.Add(tableID, activeTables[tableID]);
        activeTables.Remove(tableID);
        UpdateActiveTables();
    }

    public void AddNewOrder(int tableID, Order newOrder)
    {
        if(!IsTableActive(tableID))
        {
            WriteTableError(tableID);
            return;
        }

        activeTables[tableID].Add(newOrder);
    }

    public Order GetOrder(int tableID, int orderID)
    {
        if (!IsTableActive(tableID))
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
        if (!IsTableActive(tableID))
        {
            WriteTableError(tableID);
            return null;
        }

        return activeTables[tableID];
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }

    void UpdateActiveTables()
    {
        if (updateActiveTablesEvent != null)
        {
            Delegate[] invkList = updateActiveTablesEvent.GetInvocationList();
            List<int> activeTablesIDs = new List<int>(activeTables.Keys);

            foreach (UpdateActiveTablesDelegate handler in invkList)
            {
                new Thread(() => {
                    try
                    {
                        handler(activeTablesIDs);
                        Console.WriteLine("Invoking event handler");
                    }
                    catch (Exception)
                    {
                        updateActiveTablesEvent -= handler;
                        Console.WriteLine("Exception: Removed an event handler");
                    }
                }).Start();
            }
        }
    }
}
