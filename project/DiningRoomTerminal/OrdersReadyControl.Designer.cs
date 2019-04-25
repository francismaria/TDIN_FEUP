namespace DiningRoomTerminal
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
            this.ordersDeliveredBox = new System.Windows.Forms.ListBox();
            this.deliveredBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordersDeliveredBox
            // 
            this.ordersDeliveredBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersDeliveredBox.FormattingEnabled = true;
            this.ordersDeliveredBox.ItemHeight = 51;
            this.ordersDeliveredBox.Location = new System.Drawing.Point(116, 130);
            this.ordersDeliveredBox.Name = "ordersDeliveredBox";
            this.ordersDeliveredBox.Size = new System.Drawing.Size(992, 820);
            this.ordersDeliveredBox.TabIndex = 0;
            // 
            // deliveredBtn
            // 
            this.deliveredBtn.Location = new System.Drawing.Point(1202, 761);
            this.deliveredBtn.Name = "deliveredBtn";
            this.deliveredBtn.Size = new System.Drawing.Size(347, 189);
            this.deliveredBtn.TabIndex = 1;
            this.deliveredBtn.Text = "Delivered";
            this.deliveredBtn.UseVisualStyleBackColor = true;
            this.deliveredBtn.Click += new System.EventHandler(this.DeliveredBtn_Click);
            // 
            // OrdersReadyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deliveredBtn);
            this.Controls.Add(this.ordersDeliveredBox);
            this.Name = "OrdersReadyControl";
            this.Size = new System.Drawing.Size(1640, 1056);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ordersDeliveredBox;
        private System.Windows.Forms.Button deliveredBtn;
    }
}
