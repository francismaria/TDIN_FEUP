using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Remoting;

namespace KitchenTerminal
{
    static class ConnectionObject
    {
        static IOrder_Info centralServer;
        static SendOrderToKitchenRepeater sendOrderToKitchenRepeater;

        static ConnectionObject()
        {
            Console.Write("CONNECTION OBJECT CALLED");
            RemotingConfiguration.Configure("KitchenTerminal.exe.config", false);
            centralServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));
        }

        public static void InitConnection()
        {
            Console.WriteLine("Object was Initialized");
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
