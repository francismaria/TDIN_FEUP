using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace CentralServer
{
    class CentralServer
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("CentralServer.exe.config", false);
            Console.WriteLine("Central Server is running...");
            Console.ReadLine();
        }
    }
}
