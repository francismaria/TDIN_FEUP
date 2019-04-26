namespace DiningTerminal
{
    partial class OrdersReadyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordersReadyListBox = new System.Windows.Forms.ListBox();
            this.deliveredBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordersReadyListBox
            // 
            this.ordersReadyListBox.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersReadyListBox.FormattingEnabled = true;
            this.ordersReadyListBox.ItemHeight = 45;
            this.ordersReadyListBox.Location = new System.Drawing.Point(78, 59);
            this.ordersReadyListBox.Name = "ordersReadyListBox";
            this.ordersReadyListBox.Size = new System.Drawing.Size(806, 859);
            this.ordersReadyListBox.TabIndex = 0;
            // 
            // deliveredBtn
            // 
            this.deliveredBtn.Font = new System.Drawing.Font("Nirmala UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveredBtn.Location = new System.Drawing.Point(1000, 388);
            this.deliveredBtn.Name = "deliveredBtn";
            this.deliveredBtn.Size = new System.Drawing.Size(421, 189);
            this.deliveredBtn.TabIndex = 1;
            this.deliveredBtn.Text = "Delivered";
            this.deliveredBtn.UseVisualStyleBackColor = true;
            this.deliveredBtn.Click += new System.EventHandler(this.DeliveredBtn_Click);
            // 
            // OrdersReadyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.deliveredBtn);
            this.Controls.Add(this.ordersReadyListBox);
            this.Name = "OrdersReadyControl";
            this.Size = new System.Drawing.Size(1546, 996);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ordersReadyListBox;
        private System.Windows.Forms.Button deliveredBtn;
    }
}
