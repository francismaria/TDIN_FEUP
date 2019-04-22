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
        public NewOrderControl()
        {
            InitializeComponent();
        }

        private void DrinksChoiceControl1_Load(object sender, EventArgs e)
        {
            drinksChoiceControl1.Hide();
        }

        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            drinksChoiceControl1.Show();
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
