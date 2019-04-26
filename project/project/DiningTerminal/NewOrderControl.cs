using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningTerminal
{
    public partial class NewOrderControl : UserControl
    {
        private int tableID;

        public NewOrderControl()
        {
            InitializeComponent();
        }

        public void SetTable(int tableID)
        {
            this.tableID = tableID;
            label3.Text = "Table " + tableID;
        }

        private void OrderFoodBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                //No order was selected
            } else
            {
                Order newOrder = new Order(listBox1.GetItemText(listBox1.SelectedItem), tableID, 16.99, Order.ORDER_TYPE.KITCHEN);
                ConnectionObject.SendOrder(tableID, newOrder);
            }

        }

        private void OrderDrinkBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                //No order was selected
            }
            else
            {
                Order newOrder = new Order(listBox1.GetItemText(listBox2.SelectedItem), tableID, 16.99, Order.ORDER_TYPE.BAR);
                ConnectionObject.SendOrder(tableID, newOrder);
            }
        }
    }
}
