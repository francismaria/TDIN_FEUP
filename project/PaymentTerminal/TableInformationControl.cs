using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentTerminal
{
    public partial class TableInformationControl : UserControl
    {
        private int tableID;
        Meal mealToPay;

        public TableInformationControl()
        {
            InitializeComponent();
        }

        public void SetTable(int tableID)
        {
            this.tableID = tableID;
            mealToPay = ConnectionObject.GetMealInformation(tableID);
            DisplayMealPriceToPay();
            DisplayMealOrdersDisplay();
        }

        private void DisplayMealPriceToPay()
        {
            priceLabel.Text = mealToPay.getTotalPrice().ToString();
        }

        private void DisplayMealOrdersDisplay()
        {
            foreach(Order order in mealToPay.getAllOrders())
            {
                WriteToList(mealOrdersBox, order);
            }
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
                string itemToList = order.getDescription() + Convert.ToString(order.getPrice());
                list.Items.Add(itemToList);
            }
        }

        public int GetTable()
        {
            return tableID;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConnectionObject.SetMealAsPaid(tableID);
            ConnectionObject.CloseTable(tableID);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
