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
        private readonly object updateList = new object();

        List<Order> receivedOrders = new List<Order>();

        public KitchenWindow()
        {
            ConnectionObject.ReceiveNewOrder(ReceiveOrderFunc);
            InitializeComponent();
        }

        private void PrepBtn_Click(object sender, EventArgs e)
        {
            if(ordersNotHandledBox.SelectedIndex == -1)
            {
                Console.WriteLine("No order was selected");
                return;
            }

            string[] tokens = ordersNotHandledBox.GetItemText(ordersNotHandledBox.SelectedItem).Split(' ');

            Console.WriteLine(tokens[1] + ' ' + tokens[0]);
            //ConnectionObject.UpdateOrderState(Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[0]), Order.ORDER_STATE.IN_PREPARATION);
        }

        private void SubstituteOrder(Order newOrder)
        {
            lock (updateList)
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
                string itemToList = Convert.ToString(order.getID()) + ' ' 
                    + Convert.ToString(order.getDestinationTable()) + "       " 
                    + order.getDescription();
                list.Items.Add(itemToList);
            }
        }

        private void UpdateListBoxes()
        {
            lock(updateList)
            {
                foreach (Order order in receivedOrders)
                {
                    if(order.getState() == Order.ORDER_STATE.NOT_PICKED)
                    {            
                        WriteToList(ordersNotHandledBox, order);
                    }
                    else      //Orders in preparation
                    {
                        WriteToList(ordersInPreparationBox, order);
                    }
                }
            }
        }

        delegate void ClearInPreparationListBoxCallback(ListBox list);

        private void ClearInPreparationListBox(ListBox list)
        {
            if (list.InvokeRequired)
            {
                ClearInPreparationListBoxCallback callback = new ClearInPreparationListBoxCallback(ClearInPreparationListBox);
                Invoke(callback, list);
            }
            else
            {
                ordersInPreparationBox.Items.Clear();
            }
            
        }

        delegate void ClearNotHandledListBoxCallback(ListBox list);

        private void ClearNotHandledListBox(ListBox list)
        {
            if (list.InvokeRequired)
            {
                ClearNotHandledListBoxCallback callback = new ClearNotHandledListBoxCallback(ClearNotHandledListBox);
                Invoke(callback, list);
            }
            else
            {
                ordersNotHandledBox.Items.Clear();
            }

        }

        public void ReceiveOrderFunc(Order newOrder)
        {
            SubstituteOrder(newOrder);
            ClearNotHandledListBox(ordersNotHandledBox);
            UpdateListBoxes();
        }


    }
}
