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
    public partial class TablesControl : UserControl
    {
        public TablesControl()
        {
            InitializeComponent();
        }

        private void TablesControl_Load(object sender, EventArgs e)
        {

        }

        private void Table1_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }
        private void Table7_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table11_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table12_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }


        private void Table13_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table14_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table15_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }

        private void Table16_Click(object sender, EventArgs e)
        {
            showTablePopup();
        }
        private void showTablePopup()
        {
            TablePopupForm tablePopup = new TablePopupForm();
            DialogResult dialogresult = tablePopup.ShowDialog();
            tablePopup.Dispose();
        }
    }
}
