namespace BarTerminal
{
    partial class BarWindow
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.receivedPanel = new System.Windows.Forms.Panel();
            this.ordersNotHandledBox = new System.Windows.Forms.ListBox();
            this.prepBtn = new System.Windows.Forms.Button();
            this.receivedTitlePanel = new System.Windows.Forms.Panel();
            this.notHandledLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ordersInPreparationBox = new System.Windows.Forms.ListBox();
            this.readyBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inPrepLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.receivedPanel.SuspendLayout();
            this.receivedTitlePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1974, 204);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1974, 204);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bar Terminal";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receivedPanel
            // 
            this.receivedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivedPanel.Controls.Add(this.ordersNotHandledBox);
            this.receivedPanel.Controls.Add(this.prepBtn);
            this.receivedPanel.Controls.Add(this.receivedTitlePanel);
            this.receivedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.receivedPanel.Location = new System.Drawing.Point(0, 204);
            this.receivedPanel.Name = "receivedPanel";
            this.receivedPanel.Size = new System.Drawing.Size(994, 1060);
            this.receivedPanel.TabIndex = 1;
            // 
            // ordersNotHandledBox
            // 
            this.ordersNotHandledBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersNotHandledBox.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersNotHandledBox.FormattingEnabled = true;
            this.ordersNotHandledBox.ItemHeight = 46;
            this.ordersNotHandledBox.Location = new System.Drawing.Point(0, 146);
            this.ordersNotHandledBox.Name = "ordersNotHandledBox";
            this.ordersNotHandledBox.Size = new System.Drawing.Size(992, 763);
            this.ordersNotHandledBox.TabIndex = 2;
            // 
            // prepBtn
            // 
            this.prepBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prepBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepBtn.Location = new System.Drawing.Point(0, 909);
            this.prepBtn.Name = "prepBtn";
            this.prepBtn.Size = new System.Drawing.Size(992, 149);
            this.prepBtn.TabIndex = 1;
            this.prepBtn.Text = "Prepare";
            this.prepBtn.UseVisualStyleBackColor = true;
            this.prepBtn.Click += new System.EventHandler(this.PrepBtn_Click);
            // 
            // receivedTitlePanel
            // 
            this.receivedTitlePanel.Controls.Add(this.notHandledLabel);
            this.receivedTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.receivedTitlePanel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.receivedTitlePanel.Name = "receivedTitlePanel";
            this.receivedTitlePanel.Size = new System.Drawing.Size(992, 146);
            this.receivedTitlePanel.TabIndex = 0;
            // 
            // notHandledLabel
            // 
            this.notHandledLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.notHandledLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notHandledLabel.Location = new System.Drawing.Point(0, 0);
            this.notHandledLabel.Name = "notHandledLabel";
            this.notHandledLabel.Size = new System.Drawing.Size(992, 146);
            this.notHandledLabel.TabIndex = 0;
            this.notHandledLabel.Text = "NOT HANDLED";
            this.notHandledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ordersInPreparationBox);
            this.panel3.Controls.Add(this.readyBtn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(994, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 1060);
            this.panel3.TabIndex = 3;
            // 
            // ordersInPreparationBox
            // 
            this.ordersInPreparationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersInPreparationBox.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersInPreparationBox.FormattingEnabled = true;
            this.ordersInPreparationBox.ItemHeight = 46;
            this.ordersInPreparationBox.Location = new System.Drawing.Point(0, 146);
            this.ordersInPreparationBox.Name = "ordersInPreparationBox";
            this.ordersInPreparationBox.Size = new System.Drawing.Size(978, 763);
            this.ordersInPreparationBox.TabIndex = 3;
            // 
            // readyBtn
            // 
            this.readyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.readyBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyBtn.Location = new System.Drawing.Point(0, 909);
            this.readyBtn.Name = "readyBtn";
            this.readyBtn.Size = new System.Drawing.Size(978, 149);
            this.readyBtn.TabIndex = 2;
            this.readyBtn.Text = "Ready";
            this.readyBtn.UseVisualStyleBackColor = true;
            this.readyBtn.Click += new System.EventHandler(this.ReadyBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inPrepLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 146);
            this.panel4.TabIndex = 1;
            // 
            // inPrepLabel
            // 
            this.inPrepLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inPrepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inPrepLabel.Location = new System.Drawing.Point(0, 0);
            this.inPrepLabel.Name = "inPrepLabel";
            this.inPrepLabel.Size = new System.Drawing.Size(978, 146);
            this.inPrepLabel.TabIndex = 1;
            this.inPrepLabel.Text = "IN PREPARATION";
            this.inPrepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1264);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.receivedPanel);
            this.Controls.Add(this.panel1);
            this.Name = "BarWindow";
            this.Text = "BarWindow";
            this.panel1.ResumeLayout(false);
            this.receivedPanel.ResumeLayout(false);
            this.receivedTitlePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel receivedPanel;
        private System.Windows.Forms.Button prepBtn;
        private System.Windows.Forms.Panel receivedTitlePanel;
        private System.Windows.Forms.Label notHandledLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button readyBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label inPrepLabel;
        private System.Windows.Forms.ListBox ordersNotHandledBox;
        private System.Windows.Forms.ListBox ordersInPreparationBox;
    }
}