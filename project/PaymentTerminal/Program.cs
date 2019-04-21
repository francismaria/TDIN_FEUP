using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Threading;
using PaymentTerminal;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {


        /*Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Example());*/

        Example a = new Example();
    }
}

public partial class Example : Form
{
    public Example()
    {
        IOrder_Info centralServer;
        UpdateActiveTablesRepeater updateActiveTablesRepeater;

        RemotingConfiguration.Configure("PaymentTerminal.exe.config", false);
        centralServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));

        updateActiveTablesRepeater = new UpdateActiveTablesRepeater();
        updateActiveTablesRepeater.updateActiveTablesEvent += new UpdateActiveTablesDelegate(updateTables);
        centralServer.updateActiveTablesEvent += new UpdateActiveTablesDelegate(updateActiveTablesRepeater.Repeater);


        //int destinationTable = 10;        // --- > DEBUG ONLY

        int destinationTable = Convert.ToInt32(Console.ReadLine());

        centralServer.OpenTable(destinationTable);

        Order o1 = new Order("Bacalhau à Brás", destinationTable, 16.99, Order.ORDER_TYPE.KITCHEN);
        centralServer.AddNewOrder(destinationTable, o1);

        Console.WriteLine("ashaha" + centralServer.GetOrder(destinationTable, 1).getPrice());
        centralServer.CloseTable(destinationTable);
        Console.ReadLine();
    }

    public void updateTables(List<int> newActiveTables)
    {
        Console.WriteLine("EVENT RECEIVED!!!");
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }
}


/* Mechanism for instanciating a remote object through its interface, using the config file */

class RemoteNew {
  private static Hashtable types = null;

  private static void InitTypeTable() {
    types = new Hashtable();
    foreach (WellKnownClientTypeEntry entry in RemotingConfiguration.GetRegisteredWellKnownClientTypes())
      types.Add(entry.ObjectType, entry);
  }

  public static object New(Type type) {
    if (types == null)
      InitTypeTable();
    WellKnownClientTypeEntry entry = (WellKnownClientTypeEntry) types[type];
    if (entry == null)
      throw new RemotingException("Type not found!");
    return RemotingServices.Connect(type, entry.ObjectUrl);
  }
}
