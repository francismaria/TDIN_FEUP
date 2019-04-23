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
        public FoodChoiceControl()
        {
            InitializeComponent();
        }
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            ConnectionObject.OpenTable(5);
            Order o1 = new Order("Bacalhau à Brás", 5, 16.99, Order.ORDER_TYPE.KITCHEN);
            ConnectionObject.SendOrder(o1.getDestinationTable(), o1);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }


    }
}
