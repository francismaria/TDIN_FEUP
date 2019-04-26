using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningTerminal
{
    public partial class TablesDisplayControl : UserControl
    {
        const int NUM_TABLES = 16;
        List<int> activeTables;
        diningTerminalForm mainForm;

        public TablesDisplayControl()
        {
            InitializeComponent();
            activeTables = new List<int>();
            ConnectionObject.UpdateActiveTables(updateTablesFunc);
            updateTablesFunc(activeTables);
        }

        public void SetMainForm(diningTerminalForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void TablesDisplayControl_Load(object sender, EventArgs e)
        {

        }

        private void Table1_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 1;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 2;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 3;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 4;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 5;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 6;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table7_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 7;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 8;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 9;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 10;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table11_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 11;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table12_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 12;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table13_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 13;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table14_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 14;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table15_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 15;
            showOpenTablePopup(TABLE_ID);
        }

        private void Table16_Click(object sender, EventArgs e)
        {
            const int TABLE_ID = 16;
            showOpenTablePopup(TABLE_ID);
        }

        private void showOpenTablePopup(int tableID)
        {
            if(activeTables.Any(x => x == tableID))
            {
                mainForm.ShowNewOrderMenu(tableID);
            }
            else
            {
                OpenTablePopupForm popup = new OpenTablePopupForm();
                DialogResult dialogresult = popup.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    ConnectionObject.OpenTable(tableID);
                    mainForm.ShowNewOrderMenu(tableID);
                }

                popup.Dispose();
            }
        }

        /**
         * Function which handles the events that are received concerning the
         * tables update
         */
        public void updateTablesFunc(List<int> newActiveTables)
        {
            activeTables = newActiveTables;

            for (int i = 1; i <= NUM_TABLES; i++)
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

    }
}
