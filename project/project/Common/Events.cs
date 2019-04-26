using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -- Events -- 

/**
 *      Update active tables - Dining Room
 */

public delegate void UpdateActiveTablesDelegate(List<int> activeTablesIDs);

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

/**
 *      Sends a new order ready to the dining room - Dining Room
 */

public delegate void UpdateOrdersReadyDelegate(Order newOrderReady);

public class UpdateOrdersReadyRepeater : MarshalByRefObject
{
    public event UpdateOrdersReadyDelegate updateOrdersReadyEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Order newOrderReady)
    {
        if (updateOrdersReadyEvent != null)
            updateOrdersReadyEvent(newOrderReady);
    }
}


/**
 *      Send an order to be processed in the kitchen - Kitchen
 */

public delegate void SendOrderToKitchenDelegate(Order newOrder);

public class SendOrderToKitchenRepeater : MarshalByRefObject
{
    public event SendOrderToKitchenDelegate sendOrderToKitchenEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Order newOrder)
    {
        if (sendOrderToKitchenEvent != null)
            sendOrderToKitchenEvent(newOrder);
    }
}


/**
 *      Send an order to be processed in the bar - Bar
 */

public delegate void SendOrderToBarDelegate(Order newOrder);

public class SendOrderToBarRepeater : MarshalByRefObject
{
    public event SendOrderToBarDelegate sendOrderToBarEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Order newOrder)
    {
        if (sendOrderToBarEvent != null)
            sendOrderToBarEvent(newOrder);
    }
}

/**
 *      Send a meal so its invoice be printed
 */

public delegate void PrintMealInvoiceDelegate(Meal closedMeal);

public class PrintMealInvoiceRepeater : MarshalByRefObject
{
    public event PrintMealInvoiceDelegate printMealInvoiceEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Meal closedMeal)
    {
        if (printMealInvoiceEvent != null)
            printMealInvoiceEvent(closedMeal);
    }
}
