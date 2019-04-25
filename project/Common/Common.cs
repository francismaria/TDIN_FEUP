using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// -- Common Interface to the Central Server Remote Object "Order_Info" --

public interface IOrder_Info
{
    event UpdateActiveTablesDelegate updateActiveTablesEvent;

    event SendOrderToKitchenDelegate sendOrderToKitchenEvent;

    event SendOrderToBarDelegate sendOrderToBarEvent;

    void OpenTable(int tableID);

    void CloseTable(int tableID);

    void AddNewOrder(int tableID, Order newOrder);

    Meal GetMealInformation(int tableID);

    void UpdateKitchenOrderState(int tableID, int orderID, Order.ORDER_STATE state);

    void UpdateBarOrderState(int tableID, int orderID, Order.ORDER_STATE state);


}