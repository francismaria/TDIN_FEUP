using System;
using System.Collections;
using System.Runtime.Remoting;

namespace BarTerminal
{
    static class ConnectionObject
    {
        static IOrder_Info centralServer;
        static SendOrderToBarRepeater sendOrderToBarRepeater;

        static ConnectionObject()
        {
            Console.Write("CONNECTION OBJECT CALLED");
            RemotingConfiguration.Configure("BarTerminal.exe.config", false);
            centralServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));
        }

        public static void InitConnection()
        {
            Console.WriteLine("Object was Initialized");
        }

        public static void ReceiveNewOrder(Action<Order> ReceiveOrderFunc)
        {
            sendOrderToBarRepeater = new SendOrderToBarRepeater();
            sendOrderToBarRepeater.sendOrderToBarEvent += new SendOrderToBarDelegate(ReceiveOrderFunc);
            centralServer.sendOrderToBarEvent += new SendOrderToBarDelegate(sendOrderToBarRepeater.Repeater);
        }

        public static void UpdateOrderState(int tableID, int orderID, Order.ORDER_STATE state)
        {
            centralServer.UpdateBarOrderState(tableID, orderID, state);
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
