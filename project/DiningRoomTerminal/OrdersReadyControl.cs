using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningRoomTerminal
{
    public partial class OrdersReadyControl : UserControl
    {
        List<Order> ordersReady;

        public OrdersReadyControl()
        {
            ordersReady = new List<Order>();
            ConnectionObject.GetOrderReady(updateOrders);

            InitializeComponent();
        }

        delegate void WriteToListCallback(ListBox list, Order order);

        private void WriteToList(ListBox list, Order order)
        {
            if (list.InvokeRequired)
            {
                WriteToListCallback callback = new WriteToListCallback(WriteToList);
                Invoke(callback, list, order);
            }
            else
            {
                string itemToList = Convert.ToString(order.getID()) + ' '
                    + Convert.ToString(order.getDestinationTable()) + "       "
                    + order.getDescription();
                list.Items.Add(itemToList);
            }
        }

        public void updateOrders(Order newOrderReady)
        {
            //Has to have a LOCK
            ordersReady.Add(newOrderReady);

            DisplayNewOrders();
        }

        private void DisplayNewOrders()
        {

            foreach (Order order in ordersReady)
            {
                WriteToList(ordersDeliveredBox, order);
            }
        }

        private void DeliveredBtn_Click(object sender, EventArgs e)
        {
            //Has to have a lock on
            int orderToRemoveIndex = ordersDeliveredBox.SelectedIndex;

            if (orderToRemoveIndex == -1)
            {
                //POP UP ERROR
                Console.WriteLine("No order was selected");
                return;
            }

            ordersReady.RemoveAll(x => x.getID() == getSelectedOrderID());
            DisplayNewOrders();
        }

        private int getSelectedOrderID()
        {
            return Convert.ToInt32(ordersDeliveredBox.GetItemText(ordersDeliveredBox.SelectedItem).Split(' ')[0]);
        }
    }
}
