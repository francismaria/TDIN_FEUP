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
            SetMealPriceToPay();
        }

        private void SetMealPriceToPay()
        {
            priceLabel.Text = mealToPay.getTotalPrice().ToString();
        }

        public int GetTable()
        {
            return tableID;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(mealToPay.getAllOrders().ToString());
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
