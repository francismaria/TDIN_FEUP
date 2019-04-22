using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace DiningRoomTerminal
{
    static class ConnectionObject
    {
        static IOrder_Info centralServer;
        static UpdateActiveTablesRepeater updateActiveTablesRepeater;

        static ConnectionObject()
        {
            Console.Write("CONNECTION OBJECT CALLED");
            RemotingConfiguration.Configure("DiningRoomTerminal.exe.config", false);
            centralServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));
        }

        public static void UpdateActiveTables(Action<List<int>> updateTablesFunc)
        {
            Console.Write("Update Active tABLES" + updateTablesFunc.ToString());
            updateActiveTablesRepeater = new UpdateActiveTablesRepeater();
            updateActiveTablesRepeater.updateActiveTablesEvent += new UpdateActiveTablesDelegate(updateTablesFunc);
            centralServer.updateActiveTablesEvent += new UpdateActiveTablesDelegate(updateActiveTablesRepeater.Repeater);
        }

        static void updateActiveTables()
        {


            //int destinationTable = 10;        // --- > DEBUG ONLY

            int destinationTable = Convert.ToInt32(Console.ReadLine());

            centralServer.OpenTable(destinationTable);

            Order o1 = new Order("Bacalhau à Brás", destinationTable, 16.99, Order.ORDER_TYPE.KITCHEN);
            centralServer.AddNewOrder(destinationTable, o1);

            Console.WriteLine("ashaha" + centralServer.GetOrder(destinationTable, 1).getPrice());
            centralServer.CloseTable(destinationTable);
            Console.ReadLine();
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
