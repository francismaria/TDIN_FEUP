using System;
using System.Collections;
using System.Runtime.Remoting;

namespace Printer
{
    class PrinterTerminal
    {
        static IOrder_Info centralServer;
        static PrintMealInvoiceRepeater printMealInvoiceRepeater;

        static void Main(string[] args)
        {
            initConnection();
            getClosedMealInformation(printInvoice);

            Console.WriteLine("Printer is running...");
            Console.WriteLine("To shutdown the terminal please type 'EXIT'.");

            while (Console.ReadLine() != "EXIT")
            {
                Console.WriteLine("Unrecognized input.");
            }
        }

        public static void initConnection()
        {
            RemotingConfiguration.Configure("Printer.exe.config", false);
            centralServer = (IOrder_Info)RemoteNew.New(typeof(IOrder_Info));
        }

        public static void getClosedMealInformation(Action<Meal> printInvoiceFunc)
        {
            printMealInvoiceRepeater = new PrintMealInvoiceRepeater();
            printMealInvoiceRepeater.printMealInvoiceEvent += new PrintMealInvoiceDelegate(printInvoiceFunc);
            centralServer.printMealInvoiceEvent += new PrintMealInvoiceDelegate(printMealInvoiceRepeater.Repeater);
        }

        public static void printInvoice(Meal meal)
        {
            Console.WriteLine("-------- INVOICE FOR TABLE " + meal.getTableID().ToString() + "--------");
            Console.WriteLine("");
            Console.WriteLine("Meal Orders:");

            foreach (Order order in meal.getAllOrders())
            {
                Console.WriteLine("\t" + order.getID() + "\t" + order.getDescription() +
                    "\t" + order.getPrice());
            }

            Console.WriteLine();
            Console.WriteLine("\tTotal Price: " + meal.getTotalPrice());
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
