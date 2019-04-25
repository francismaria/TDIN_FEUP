namespace PaymentTerminal
{
    partial class TableInformationControl
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
            this.mealOrdersBox = new System.Windows.Forms.ListBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mealOrdersBox
            // 
            this.mealOrdersBox.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealOrdersBox.FormattingEnabled = true;
            this.mealOrdersBox.ItemHeight = 46;
            this.mealOrdersBox.Location = new System.Drawing.Point(282, 198);
            this.mealOrdersBox.Name = "mealOrdersBox";
            this.mealOrdersBox.Size = new System.Drawing.Size(1080, 740);
            this.mealOrdersBox.TabIndex = 3;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(1414, 751);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(431, 187);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(36, 34);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(187, 117);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(1404, 198);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(240, 58);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(1608, 326);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 65);
            this.priceLabel.TabIndex = 8;
            // 
            // TableInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.mealOrdersBox);
            this.Name = "TableInformationControl";
            this.Size = new System.Drawing.Size(1982, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mealOrdersBox;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}
