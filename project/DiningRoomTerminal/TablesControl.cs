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

        private List<int> activeTables;

        public TablesControl()
        {
            activeTables = new List<int>();

            // DEBUG
            activeTables.Add(2);
            activeTables.Add(4);

            InitializeComponent();
        }

        private void TablesControl_Load(object sender, EventArgs e)
        {

        }

        private void Table1_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 1;
            showTablePopup(TABLE_ID);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 2;
            showTablePopup(TABLE_ID);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 3;
            showTablePopup(TABLE_ID);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 4;
            showTablePopup(TABLE_ID);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 5;
            showTablePopup(TABLE_ID);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 6;
            showTablePopup(TABLE_ID);
        }
        private void Table7_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 7;
            showTablePopup(TABLE_ID);
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 8;
            showTablePopup(TABLE_ID);
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 9;
            showTablePopup(TABLE_ID);
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 10;
            showTablePopup(TABLE_ID);
        }

        private void Table11_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 11;
            showTablePopup(TABLE_ID);
        }

        private void Table12_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 12;
            showTablePopup(TABLE_ID);
        }

        private void Table13_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 13;
            showTablePopup(TABLE_ID);
        }

        private void Table14_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 14;
            showTablePopup(TABLE_ID);
        }

        private void Table15_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 15;
            showTablePopup(TABLE_ID);
        }

        private void Table16_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 16;
            showTablePopup(TABLE_ID);
        }

        private void showTablePopup(int tableID)
        {
            TablePopupForm tablePopup;
            DialogResult dialogresult;

            if (isTableActive(tableID))
            {
                tablePopup = new TablePopupForm(tableID, true);
                dialogresult = tablePopup.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    //openTable
                    Console.WriteLine("CLOSE TABLE " +  tableID);
                }
            } else {
                tablePopup = new TablePopupForm(tableID, false);
                dialogresult = tablePopup.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    //closeTable
                    Console.WriteLine("OPEN TABLE " +  tableID);
                }
            }
            tablePopup.Dispose();
        }

        private bool isTableActive(int tableID)
        {
            foreach(int id in activeTables)
            {
                if (id == tableID)
                    return true;
            }
            return false;
        }
    }
}
