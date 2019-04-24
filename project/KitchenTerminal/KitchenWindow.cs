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
    public partial class KitchenWindow : Form
    {
        List<Order> receivedOrders = new List<Order>();

        public KitchenWindow()
        {
            ConnectionObject.ReceiveNewOrder(ReceiveOrderFunc);
            InitializeComponent();
        }

        private void PrepBtn_Click(object sender, EventArgs e)
        {
            ordersNotHandledBox.GetItemText(ordersNotHandledBox.SelectedItem);
            Console.WriteLine(ordersNotHandledBox.GetItemText(ordersNotHandledBox.SelectedItem));
            //ConnectionObject.UpdateOrderState();
        }

        private void SubstituteOrder(Order newOrder)
        {
            int index = receivedOrders.FindIndex(ind => ind.Equals(newOrder));
            if (index != -1)
            {
                receivedOrders[index] = newOrder;
            }
            else
            {
                receivedOrders.Add(newOrder);
            }
        }

        delegate void WriteToListCallback(ListBox list, Order order);

        private void WriteToList(ListBox list, Order order)
        {
            if(list.InvokeRequired)
            {
                WriteToListCallback callback = new WriteToListCallback(WriteToList);
                Invoke(callback, list, order);
            }
            else
            {
                list.Items.Add(order.getID() + ' ' + order.getDescription());
            }

        }

        private void UpdateListBoxes()
        {
            foreach(Order order in receivedOrders)
            {
                if(order.getState() == Order.ORDER_STATE.NOT_PICKED)
                {
                    WriteToList(ordersNotHandledBox, order);
                    //ordersNotHandledBox.Items.Add(order.getID() + ' ' + order.getDescription());
                }
                else      //Orders in preparation
                {
                    WriteToList(ordersInPreparationBox, order);
                    //ordersInPreparationBox.Items.Add(order.getID() + ' ' + order.getDescription());
                }
            }
        }

        public void ReceiveOrderFunc(Order newOrder)
        {
            SubstituteOrder(newOrder);
            UpdateListBoxes();
        }


    }
}
