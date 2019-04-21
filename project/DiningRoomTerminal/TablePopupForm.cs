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
    public partial class TablePopupForm : Form
    {
        int tableID;
        bool active;

        public TablePopupForm(int tableID, bool active)
        {
            this.tableID = tableID;
            this.active = active;
            InitializeComponent();
            if (active)
                this.hideCloseButton();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TablePopupForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenTable_Click(object sender, EventArgs e)
        {

        }

        private void CloseTableBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
