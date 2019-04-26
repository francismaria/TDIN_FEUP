using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace DiningTerminal
{
    static class ConnectionObject
    {
        static IOrder_Info centralServer;

        static UpdateActiveTablesRepeater updateActiveTablesRepeater;

        static UpdateOrdersReadyRepeater updateOrdersReadyRepeater;

        static ConnectionObject()
        {
            Console.Write("CONNECTION OBJECT CALLED");
            RemotingConfiguration.Configure("DiningTerminal.exe.config", false);
            centralServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));
        }

        /* ------------------------------------
         *          Event Receivers
         * ------------------------------------ */
        public static void UpdateActiveTables(Action<List<int>> updateTablesFunc)
        {
            updateActiveTablesRepeater = new UpdateActiveTablesRepeater();
            updateActiveTablesRepeater.updateActiveTablesEvent += new UpdateActiveTablesDelegate(updateTablesFunc);
            centralServer.updateActiveTablesEvent += new UpdateActiveTablesDelegate(updateActiveTablesRepeater.Repeater);
        }

        public static void GetOrderReady(Action<Order> updateOrdersReadyFunc)
        {
            updateOrdersReadyRepeater = new UpdateOrdersReadyRepeater();
            updateOrdersReadyRepeater.updateOrdersReadyEvent += new UpdateOrdersReadyDelegate(updateOrdersReadyFunc);
            centralServer.updateOrdersReadyEvent += new UpdateOrdersReadyDelegate(updateOrdersReadyRepeater.Repeater);
        }

        /* ------------------------------------
         *          Messages To Server
         * ------------------------------------ */
        public static void OpenTable(int tableID)
        {
            centralServer.OpenTable(tableID);
        }

        public static void SendOrder(int tableID, Order newOrder)
        {
            centralServer.AddNewOrder(tableID, newOrder);
        }

        public static List<int> GetActiveTables()
        {
            return centralServer.GetActiveTables();
        }
    }
}

/* Mechanism for instanciating a remote object through its interface, using the config file */
class RemoteNew
{
    private static Hashtable types = null;

    private static void InitTypeTable()
    {
        types = new Hashtable();
        foreach (WellKnownClientTypeEntry entry in RemotingConfiguration.GetRegisteredWellKnownClientTypes())
            types.Add(entry.ObjectType, entry);
    }

    public static object New(Type type)
    {
        if (types == null)
            InitTypeTable();
        WellKnownClientTypeEntry entry = (WellKnownClientTypeEntry)types[type];
        if (entry == null)
            throw new RemotingException("Type not found!");
        return RemotingServices.Connect(type, entry.ObjectUrl);
    }
}