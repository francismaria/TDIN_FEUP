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

            //ordersServer.AddNewOrder();
            Console.WriteLine("ashaha" + ordersServer.GetPrice());

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
