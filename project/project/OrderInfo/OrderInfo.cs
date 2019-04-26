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

    public event UpdateOrdersReadyDelegate updateOrdersReadyEvent;

    public event SendOrderToKitchenDelegate sendOrderToKitchenEvent;

    public event SendOrderToBarDelegate sendOrderToBarEvent;

    public event PrintMealInvoiceDelegate printMealInvoiceEvent;

    public static int IDCounter = 0;

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

        /*if(!checkIfAllMealOrdersArePaid())
        {
            Console.WriteLine("Not all orders are paid");      //Send an error message to appear
            return;
        }*/

        if (!mealsHistory.ContainsKey(tableID))
            mealsHistory.Add(tableID, new List<Meal>());

        PrintMealInvoice(activeTables[tableID]);
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

        updateOrderID(newOrder);
        activeTables[tableID].addOrder(newOrder);

        if(newOrder.getType() == Order.ORDER_TYPE.KITCHEN)
            SendOrderToKitchen(newOrder);
        else
        {
            SendOrderToBar(newOrder);
        }   
    }

    private void updateOrderID(Order newOrder)
    {
        newOrder.setID(IDCounter);
        IDCounter = System.Threading.Interlocked.Increment(ref IDCounter);
    }

    public Meal GetMealInformation(int tableID)
    {
        return activeTables[tableID];
    }

    public void SetMealAsPaid(int tableID)
    {
        if (!activeTables.ContainsKey(tableID))
            return;

        activeTables[tableID].setAsPaid();
    }

    public void UpdateKitchenOrderState(int tableID, int orderID, Order.ORDER_STATE state)
    {
        if(!IsTableActive(tableID))
        {
            Console.WriteLine("Table is not active.");
            return;
        }

        if(state == Order.ORDER_STATE.READY)
        {
            activeTables[tableID].getOrder(orderID).setState(state);
            UpdateOrdersReady(activeTables[tableID].getOrder(orderID));
            return;
        }

        activeTables[tableID].getOrder(orderID).setState(state);
        SendOrderToKitchen(activeTables[tableID].getOrder(orderID));
    }


    public void UpdateBarOrderState(int tableID, int orderID, Order.ORDER_STATE state)
    {
        if (!IsTableActive(tableID))
        {
            Console.WriteLine("Table is not active.");
            return;
        }

        activeTables[tableID].getOrder(orderID).setState(state);
        SendOrderToBar(activeTables[tableID].getOrder(orderID));
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }

    /** ---------------------------------------
     *          Event Propagations
     *  --------------------------------------- */
    
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

    void UpdateOrdersReady(Order orderReady)
    {
        if (updateOrdersReadyEvent != null)
        {
            Delegate[] invkList = updateOrdersReadyEvent.GetInvocationList();

            foreach (UpdateOrdersReadyDelegate handler in invkList)
            {
                new Thread(() => {
                    try
                    {
                        handler(orderReady);
                        Console.WriteLine("Invoking event handler");
                    }
                    catch (Exception)
                    {
                        updateOrdersReadyEvent -= handler;
                        Console.WriteLine("Exception: Removed an event handler");
                    }
                }).Start();
            }
        }
    }

    void SendOrderToKitchen(Order newOrder)
    {
        if (sendOrderToKitchenEvent != null)
        {
            Delegate[] invkList = sendOrderToKitchenEvent.GetInvocationList();

            foreach (SendOrderToKitchenDelegate handler in invkList)
            {
                new Thread(() => {
                    try
                    {
                        handler(newOrder);
                        Console.WriteLine("Invoking event handler");
                    }
                    catch (Exception)
                    {
                        sendOrderToKitchenEvent -= handler;
                        Console.WriteLine("Exception: Removed an event handler");
                    }
                }).Start();
            }
        }
    }

    void SendOrderToBar(Order newOrder)
    {
        if (sendOrderToBarEvent != null)
        {
            Delegate[] invkList = sendOrderToBarEvent.GetInvocationList();

            foreach (SendOrderToBarDelegate handler in invkList)
            {
                new Thread(() => {
                    try
                    {
                        handler(newOrder);
                        Console.WriteLine("Invoking event handler");
                    }
                    catch (Exception)
                    {
                        sendOrderToBarEvent -= handler;
                        Console.WriteLine("Exception: Removed an event handler");
                    }
                }).Start();
            }
        }
    }


    void PrintMealInvoice(Meal closedMeal)
    {
        if (printMealInvoiceEvent != null)
        {
            Delegate[] invkList = printMealInvoiceEvent.GetInvocationList();

            foreach (PrintMealInvoiceDelegate handler in invkList)
            {
                new Thread(() => {
                    try
                    {
                        handler(closedMeal);
                        Console.WriteLine("Invoking event handler");
                    }
                    catch (Exception)
                    {
                        printMealInvoiceEvent -= handler;
                        Console.WriteLine("Exception: Removed an event handler");
                    }
                }).Start();
            }
        }
    }
}
