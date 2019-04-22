namespace DiningRoomTerminal
{
    partial class DrinksChoiceControl
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
            System.Windows.Forms.ListBox listBox1;
            this.orderBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] {
            "Gin Tónico",
            "Martini",
            "Whiskey",
            "Vodka",
            "Coca-Cola 1lt",
            "Água Natural 1,5lt",
            "Água Natural 0.5lt"});
            listBox1.Location = new System.Drawing.Point(138, 112);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(984, 954);
            listBox1.TabIndex = 2;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(1252, 324);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(325, 141);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1252, 729);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(325, 141);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DrinksChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(listBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.orderBtn);
            this.Name = "DrinksChoiceControl";
            this.Size = new System.Drawing.Size(1744, 1206);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button backBtn;
    }
}
