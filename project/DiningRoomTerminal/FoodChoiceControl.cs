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
    public partial class FoodChoiceControl : UserControl
    {
        private int tableID;

        public FoodChoiceControl()
        {
            InitializeComponent();
        }

        public void SetTable(int tableID)
        {
            this.tableID = tableID;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            ConnectionObject.OpenTable(tableID);
            Order o1 = new Order("Bacalhau à Brás", tableID, 16.99, Order.ORDER_TYPE.KITCHEN);
            ConnectionObject.SendOrder(o1.getDestinationTable(), o1);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }


    }
}
