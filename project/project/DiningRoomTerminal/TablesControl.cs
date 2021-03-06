﻿using System;
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
        private const int NUM_TABLES = 16;
        private List<int> activeTables;

        public TablesControl()
        {
            InitializeComponent();
            activeTables = new List<int>();

            ConnectionObject.UpdateActiveTables(updateTables);
            updateTables(activeTables);
        }

        private void TablesControl_Load(object sender, EventArgs e)
        {
            newOrderControl1.Hide();
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

        public void resetPresentation()
        {
            newOrderControl1.hideAll();
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
                    //Add new Order
                    Console.WriteLine("CLOSE TABLE " +  tableID);
                }
            } else {
                tablePopup = new TablePopupForm(tableID, false);
                dialogresult = tablePopup.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    newOrderControl1.SetTable(tableID);
                    newOrderControl1.Show();
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

        /**
         * Function which handles the events that are received concerning the
         * tables update
         */
        public void updateTables(List<int> newActiveTables)
        {
            activeTables = newActiveTables;

            for(int i = 1; i <= NUM_TABLES; i++)
            {
                var btnToActivate = "table" + i.ToString();
                var btn = Controls.OfType<Button>().FirstOrDefault(b => b.Name == btnToActivate);

                if (activeTables.Any(x => x == i))
                {
                    btn.BackColor = Color.Green;
                } 
                else
                {
                    btn.BackColor = Color.Red;
                }
            }
        }

        private void NewOrderControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
