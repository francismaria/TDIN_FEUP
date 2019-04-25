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
        }

        private void DrinksChoiceControl1_Load(object sender, EventArgs e)
        {
            drinksChoiceControl1.Hide();
        }

        private void FoodChoiceControl1_Load(object sender, EventArgs e)
        {
            foodChoiceControl1.Hide();
        }

        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            //drinksChoiceControl1.SetTable(tableID);
            drinksChoiceControl1.Show();
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            foodChoiceControl1.SetTable(tableID);
            foodChoiceControl1.Show();
        }

        public void hideAll()
        {
            drinksChoiceControl1.Hide();
            foodChoiceControl1.Hide();
            Hide();
        }


    }
}
