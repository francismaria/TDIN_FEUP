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

        public TablePopupForm(int tableID, bool active)
        {
            InitializeComponent();
            if (!active)
            {
                hideCloseButton();
                hideCloseLabel();
            }
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
