using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentTerminal
{
    public partial class PaymentTerminalWindow : Form
    {
        public PaymentTerminalWindow()
        {
            TablesDisplayControl tablesDisplay = new TablesDisplayControl();
            InitializeComponent();
            panel2.Controls.Add(tablesDisplay);
            tablesDisplay.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
