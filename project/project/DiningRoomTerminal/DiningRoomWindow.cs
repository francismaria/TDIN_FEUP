using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningRoomTerminal
{
    public partial class DiningRoomWindow : Form
    {
        public DiningRoomWindow()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablesControl.Show();
            ordersReadyControl.Hide();
            ordersInfoControl.Hide();
        }

        private void TablesBtn_Click(object sender, EventArgs e)
        {
            tablesControl.resetPresentation();
            tablesControl.Show();
            ordersReadyControl.Hide();
            ordersInfoControl.Hide();
        }

        private void OrdersReadyBtn_Click(object sender, EventArgs e)
        {
            tablesControl.resetPresentation();
            tablesControl.Hide();
            ordersReadyControl.Show();
            ordersInfoControl.Hide();
        }

        private void OrdersInfoBtn_Click(object sender, EventArgs e)
        {
            tablesControl.resetPresentation();
            tablesControl.Hide();
            ordersReadyControl.Hide();
            ordersInfoControl.Show();
        }

        private void TablesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersInfoControl1_Load(object sender, EventArgs e)
        {

        }


    }
}
