using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class OrderInfo : MarshalByRefObject, IOrder_Info
{

    Dictionary<int, Meal> activeTables = new Dictionary<int, Meal>();

    Dictionary<int, List<Meal>> mealsHistory = new Dictionary<int, List<Meal>>();

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

    public void OpenTable(int tableID)
    {
        if(IsTableActive(tableID))
        {   
            Console.WriteLine("Table is already opened.");      //Send an error message to appear
            return;
        }

        Meal newMeal = new Meal(tableID);
        activeTables.Add(tableID, newMeal);
        UpdateActiveTables();
    }

    public void CloseTable(int tableID)
    {
        if(!IsTableActive(tableID))
        {
            Console.WriteLine("Table is not active.");      //Send an error message to appear
            return;
        }

        if (!mealsHistory.ContainsKey(tableID))
            mealsHistory.Add(tableID, new List<Meal>());

        mealsHistory[tableID].Add(activeTables[tableID]);
        activeTables.Remove(tableID);
        UpdateActiveTables();
    }

    public void AddNewOrder(int tableID, Order newOrder)
    {
        if(!IsTableActive(tableID))
        {
            return;
        }

        activeTables[tableID].addOrder(newOrder);
    }

    public Order GetOrder(int tableID, int orderID)
    {
        if (!IsTableActive(tableID))
        {
           // WriteTableError(tableID);
            return null;
        }

        return activeTables[tableID].getOrder(orderID);
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
