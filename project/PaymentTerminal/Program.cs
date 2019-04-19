using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;

namespace PaymentTerminal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IOrder_Info ordersServer;

            RemotingConfiguration.Configure("PaymentTerminal.exe.config", false);
            ordersServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));

            const int destinationTable = 10;        //DEBUG ONLY

            ordersServer.OpenTable(10);

            Order o1 = new Order("Bacalhau à Brás", destinationTable, 16.99, Order.ORDER_TYPE.KITCHEN);
            ordersServer.AddNewOrder(destinationTable, o1);
           
            Console.WriteLine("ashaha" + ordersServer.GetOrder(destinationTable, 1).getPrice());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

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
}
