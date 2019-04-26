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
            int intTemp = Convert.ToInt32(Console.ReadLine());
            ConnectionObject.UpdateOrderState(4, 2, Order.ORDER_STATE.IN_PREPARATION);
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
            if (index == -1)
            {
                preparingOrders.Add(newOrder);
            } else
            {
                preparingOrders[index] = newOrder;
            }

            foreach (Order order in preparingOrders)
            {
                Console.WriteLine(order.getState());
            }
        }
    }
}
