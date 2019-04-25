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
    public partial class TablesDisplayControl : UserControl
    {
        public TablesDisplayControl()
        {
            InitializeComponent();
            tableInformationControl1.Hide();
        }

        private void Table1_Click(object sender, EventArgs e)
        {
            const int tableID = 1;
            showTableInformation(tableID);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            const int tableID = 2;
            showTableInformation(tableID);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            const int tableID = 3;
            showTableInformation(tableID);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            const int tableID = 4;
            showTableInformation(tableID);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            const int tableID = 5;
            showTableInformation(tableID);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            const int tableID = 6;
            showTableInformation(tableID);
        }

        private void Table7_Click(object sender, EventArgs e)
        {
            const int tableID = 7;
            showTableInformation(tableID);
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            const int tableID = 8;
            showTableInformation(tableID);
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            const int tableID = 9;
            showTableInformation(tableID);
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            const int tableID = 10;
            showTableInformation(tableID);
        }

        private void Table11_Click(object sender, EventArgs e)
        {
            const int tableID = 11;
            showTableInformation(tableID);
        }

        private void Table12_Click(object sender, EventArgs e)
        {
            const int tableID = 12;
            showTableInformation(tableID);
        }

        private void Table13_Click(object sender, EventArgs e)
        {
            const int tableID = 13;
            showTableInformation(tableID);
        }

        private void Table14_Click(object sender, EventArgs e)
        {
            const int tableID = 14;
            showTableInformation(tableID);
        }

        private void Table15_Click(object sender, EventArgs e)
        {
            const int tableID = 15;
            showTableInformation(tableID);
        }

        private void Table16_Click(object sender, EventArgs e)
        {
            const int tableID = 16;
            showTableInformation(tableID);
        }

        private void showTableInformation(int tableID)
        {
            tableInformationControl1.SetTable(tableID);
            tableInformationControl1.Show();

        }

    }
}
