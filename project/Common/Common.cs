using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// -- Common Interface --

public interface IOrder_Info
{
    event UpdateActiveTablesDelegate updateActiveTablesEvent;

    event SendOrderToKitchenDelegate sendOrderToKitchenEvent;

    event SendOrderToBarDelegate sendOrderToBarEvent;

    void OpenTable(int tableID);

    void CloseTable(int tableID);

    void UpdateOrderState(int tableID, int orderID, Order.ORDER_STATE state);

    void AddNewOrder(int tableID, Order newOrder);
    
    Order GetOrder(int tableID, int orderID);


}