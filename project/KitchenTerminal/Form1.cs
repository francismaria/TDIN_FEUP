using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenTerminal
{
    public partial class Form1 : Form
    {
        List<Order> preparingOrders = new List<Order>();

        public Form1()
        {
            ConnectionObject.InitConnection();
            InitializeComponent();
            ConnectionObject.ReceiveNewOrder(receiveOrderFunc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void receiveOrderFunc(Order newOrder)
        {
            Console.WriteLine("ORDER HAS ARRIVED. " + newOrder.getDestinationTable() + newOrder.getID());
            substituteOrder(newOrder);
            Console.WriteLine(preparingOrders.ToString());
        }

        private void substituteOrder(Order newOrder)
        {
            int index = preparingOrders.FindIndex(ind => ind.Equals(newOrder));
            if (index != -1)
            {
                preparingOrders[index] = newOrder;
            }
        }
    }
}
