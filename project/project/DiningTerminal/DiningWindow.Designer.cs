namespace DiningTerminal
{
    partial class diningTerminalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ordersReadyBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectedPanel = new System.Windows.Forms.Panel();
            this.tablesBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ordersReadyControl1 = new DiningTerminal.OrdersReadyControl();
            this.tablesDisplayControl1 = new DiningTerminal.TablesDisplayControl();
            this.newOrderControl1 = new DiningTerminal.NewOrderControl();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ordersReadyBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.selectedPanel);
            this.panel1.Controls.Add(this.tablesBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 1234);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(2, 723);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(413, 200);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tables";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ordersReadyBtn
            // 
            this.ordersReadyBtn.FlatAppearance.BorderSize = 0;
            this.ordersReadyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersReadyBtn.Font = new System.Drawing.Font("Yu Gothic UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersReadyBtn.ForeColor = System.Drawing.Color.White;
            this.ordersReadyBtn.Location = new System.Drawing.Point(2, 529);
            this.ordersReadyBtn.Name = "ordersReadyBtn";
            this.ordersReadyBtn.Size = new System.Drawing.Size(413, 200);
            this.ordersReadyBtn.TabIndex = 4;
            this.ordersReadyBtn.Text = "Orders Ready";
            this.ordersReadyBtn.UseVisualStyleBackColor = true;
            this.ordersReadyBtn.Click += new System.EventHandler(this.OrdersReadyBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 200);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tables";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // selectedPanel
            // 
            this.selectedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.selectedPanel.Location = new System.Drawing.Point(3, 332);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(27, 200);
            this.selectedPanel.TabIndex = 2;
            this.selectedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectedPanel_Paint);
            // 
            // tablesBtn
            // 
            this.tablesBtn.FlatAppearance.BorderSize = 0;
            this.tablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesBtn.Font = new System.Drawing.Font("Yu Gothic UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesBtn.ForeColor = System.Drawing.Color.White;
            this.tablesBtn.Location = new System.Drawing.Point(0, 332);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(413, 200);
            this.tablesBtn.TabIndex = 1;
            this.tablesBtn.Text = "Tables";
            this.tablesBtn.UseVisualStyleBackColor = true;
            this.tablesBtn.Click += new System.EventHandler(this.TablesBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 232);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.newOrderControl1);
            this.panel4.Controls.Add(this.ordersReadyControl1);
            this.panel4.Controls.Add(this.tablesDisplayControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(416, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1546, 996);
            this.panel4.TabIndex = 1;
            // 
            // ordersReadyControl1
            // 
            this.ordersReadyControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ordersReadyControl1.Location = new System.Drawing.Point(0, 0);
            this.ordersReadyControl1.Name = "ordersReadyControl1";
            this.ordersReadyControl1.Size = new System.Drawing.Size(1546, 996);
            this.ordersReadyControl1.TabIndex = 1;
            this.ordersReadyControl1.Load += new System.EventHandler(this.OrdersReadyControl1_Load);
            // 
            // tablesDisplayControl1
            // 
            this.tablesDisplayControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tablesDisplayControl1.Location = new System.Drawing.Point(-3, -3);
            this.tablesDisplayControl1.Name = "tablesDisplayControl1";
            this.tablesDisplayControl1.Size = new System.Drawing.Size(1546, 996);
            this.tablesDisplayControl1.TabIndex = 0;
            // 
            // newOrderControl1
            // 
            this.newOrderControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.newOrderControl1.Location = new System.Drawing.Point(0, -3);
            this.newOrderControl1.Name = "newOrderControl1";
            this.newOrderControl1.Size = new System.Drawing.Size(1546, 996);
            this.newOrderControl1.TabIndex = 2;
            // 
            // diningTerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1962, 1234);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "diningTerminalForm";
            this.Text = "Dining Terminal";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tablesBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ordersReadyBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel selectedPanel;
        private System.Windows.Forms.Panel panel4;
        private TablesDisplayControl tablesDisplayControl1;
        private OrdersReadyControl ordersReadyControl1;
        private NewOrderControl newOrderControl1;
    }
}

