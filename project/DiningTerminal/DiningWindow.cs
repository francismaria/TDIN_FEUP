using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningTerminal
{
    public partial class diningTerminalForm : Form
    {
        public diningTerminalForm()
        {
            InitializeComponent();
            selectedPanel.Height = tablesBtn.Height;
            selectedPanel.Top = tablesBtn.Top;
            tablesDisplayControl1.SetMainForm(this);
            tablesDisplayControl1.BringToFront();
        }

        private void TablesBtn_Click(object sender, EventArgs e)
        {
            selectedPanel.Height = tablesBtn.Height;
            selectedPanel.Top = tablesBtn.Top;
            tablesDisplayControl1.SetMainForm(this);
            tablesDisplayControl1.BringToFront();
        }

        private void OrdersReadyBtn_Click(object sender, EventArgs e)
        {
            selectedPanel.Height = ordersReadyBtn.Height;
            selectedPanel.Top = ordersReadyBtn.Top;
            ordersReadyControl1.BringToFront();
        }

        private void SelectedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersReadyControl1_Load(object sender, EventArgs e)
        {

        }

        public void ShowNewOrderMenu(int tableID)
        {
            newOrderControl1.SetTable(tableID);
            newOrderControl1.BringToFront();
        }
    }
}
