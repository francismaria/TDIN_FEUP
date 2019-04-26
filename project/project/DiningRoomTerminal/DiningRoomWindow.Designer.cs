namespace DiningRoomTerminal
{
    partial class DiningRoomWindow
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
            this.btnsPanel = new System.Windows.Forms.Panel();
            this.ordersInfoBtn = new System.Windows.Forms.Button();
            this.ordersReadyBtn = new System.Windows.Forms.Button();
            this.tablesBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersInfoControl = new DiningRoomTerminal.OrdersInfoControl();
            this.ordersReadyControl = new DiningRoomTerminal.OrdersReadyControl();
            this.tablesControl = new DiningRoomTerminal.TablesControl();
            this.btnsPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsPanel
            // 
            this.btnsPanel.BackColor = System.Drawing.Color.DimGray;
            this.btnsPanel.Controls.Add(this.ordersInfoBtn);
            this.btnsPanel.Controls.Add(this.ordersReadyBtn);
            this.btnsPanel.Controls.Add(this.tablesBtn);
            this.btnsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsPanel.Location = new System.Drawing.Point(0, 0);
            this.btnsPanel.Name = "btnsPanel";
            this.btnsPanel.Size = new System.Drawing.Size(358, 1402);
            this.btnsPanel.TabIndex = 0;
            // 
            // ordersInfoBtn
            // 
            this.ordersInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.ordersInfoBtn.FlatAppearance.BorderSize = 0;
            this.ordersInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersInfoBtn.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordersInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersInfoBtn.Location = new System.Drawing.Point(0, 661);
            this.ordersInfoBtn.Name = "ordersInfoBtn";
            this.ordersInfoBtn.Size = new System.Drawing.Size(358, 116);
            this.ordersInfoBtn.TabIndex = 3;
            this.ordersInfoBtn.Text = "Orders Info";
            this.ordersInfoBtn.UseVisualStyleBackColor = false;
            this.ordersInfoBtn.Click += new System.EventHandler(this.OrdersInfoBtn_Click);
            // 
            // ordersReadyBtn
            // 
            this.ordersReadyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ordersReadyBtn.FlatAppearance.BorderSize = 0;
            this.ordersReadyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersReadyBtn.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersReadyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordersReadyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersReadyBtn.Location = new System.Drawing.Point(0, 523);
            this.ordersReadyBtn.Name = "ordersReadyBtn";
            this.ordersReadyBtn.Size = new System.Drawing.Size(358, 116);
            this.ordersReadyBtn.TabIndex = 2;
            this.ordersReadyBtn.Text = "Orders Ready";
            this.ordersReadyBtn.UseVisualStyleBackColor = false;
            this.ordersReadyBtn.Click += new System.EventHandler(this.OrdersReadyBtn_Click);
            // 
            // tablesBtn
            // 
            this.tablesBtn.BackColor = System.Drawing.Color.Transparent;
            this.tablesBtn.FlatAppearance.BorderSize = 0;
            this.tablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesBtn.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tablesBtn.Location = new System.Drawing.Point(0, 389);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(358, 116);
            this.tablesBtn.TabIndex = 0;
            this.tablesBtn.Text = "Tables";
            this.tablesBtn.UseVisualStyleBackColor = false;
            this.tablesBtn.Click += new System.EventHandler(this.TablesBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(358, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1744, 196);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dining Room Terminal";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ordersInfoControl
            // 
            this.ordersInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersInfoControl.Location = new System.Drawing.Point(358, 196);
            this.ordersInfoControl.Name = "ordersInfoControl";
            this.ordersInfoControl.Size = new System.Drawing.Size(1744, 1206);
            this.ordersInfoControl.TabIndex = 4;
            this.ordersInfoControl.Load += new System.EventHandler(this.OrdersInfoControl1_Load);
            // 
            // ordersReadyControl
            // 
            this.ordersReadyControl.Location = new System.Drawing.Point(358, 195);
            this.ordersReadyControl.Name = "ordersReadyControl";
            this.ordersReadyControl.Size = new System.Drawing.Size(1640, 1056);
            this.ordersReadyControl.TabIndex = 3;
            // 
            // tablesControl
            // 
            this.tablesControl.Location = new System.Drawing.Point(358, 195);
            this.tablesControl.Name = "tablesControl";
            this.tablesControl.Size = new System.Drawing.Size(1640, 1059);
            this.tablesControl.TabIndex = 2;
            // 
            // DiningRoomWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2102, 1402);
            this.Controls.Add(this.ordersInfoControl);
            this.Controls.Add(this.ordersReadyControl);
            this.Controls.Add(this.tablesControl);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.btnsPanel);
            this.Name = "DiningRoomWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnsPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnsPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tablesBtn;
        private System.Windows.Forms.Button ordersReadyBtn;
        private System.Windows.Forms.Button ordersInfoBtn;
        private TablesControl tablesControl;
        private OrdersReadyControl ordersReadyControl;
        private OrdersInfoControl ordersInfoControl;
    }
}

