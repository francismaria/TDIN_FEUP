namespace DiningTerminal
{
    partial class NewOrderControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.orderFoodBtn = new System.Windows.Forms.Button();
            this.orderDrinkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 45;
            this.listBox1.Items.AddRange(new object[] {
            "Bacalhau à Brás ",
            "Arroz de Lampreia ",
            "Arroz de Marisco ",
            "Jardineira ",
            "Bacalhau c/ Natas "});
            this.listBox1.Location = new System.Drawing.Point(78, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(622, 679);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 45;
            this.listBox2.Items.AddRange(new object[] {
            "Água Natural 1,5l",
            "Coca-Cola 0,33l",
            "Fanta 0,33l",
            "Sprite 0,33l",
            "Martini",
            "Bacardi",
            "Whiskey"});
            this.listBox2.Location = new System.Drawing.Point(834, 137);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(622, 679);
            this.listBox2.TabIndex = 1;
            // 
            // orderFoodBtn
            // 
            this.orderFoodBtn.Location = new System.Drawing.Point(78, 848);
            this.orderFoodBtn.Name = "orderFoodBtn";
            this.orderFoodBtn.Size = new System.Drawing.Size(622, 107);
            this.orderFoodBtn.TabIndex = 2;
            this.orderFoodBtn.Text = "Order Food";
            this.orderFoodBtn.UseVisualStyleBackColor = true;
            this.orderFoodBtn.Click += new System.EventHandler(this.OrderFoodBtn_Click);
            // 
            // orderDrinkBtn
            // 
            this.orderDrinkBtn.Location = new System.Drawing.Point(834, 848);
            this.orderDrinkBtn.Name = "orderDrinkBtn";
            this.orderDrinkBtn.Size = new System.Drawing.Size(622, 107);
            this.orderDrinkBtn.TabIndex = 3;
            this.orderDrinkBtn.Text = "Order Drink";
            this.orderDrinkBtn.UseVisualStyleBackColor = true;
            this.orderDrinkBtn.Click += new System.EventHandler(this.OrderDrinkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(308, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1061, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drinks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(682, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 52);
            this.label3.TabIndex = 6;
            // 
            // NewOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDrinkBtn);
            this.Controls.Add(this.orderFoodBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "NewOrderControl";
            this.Size = new System.Drawing.Size(1546, 996);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button orderFoodBtn;
        private System.Windows.Forms.Button orderDrinkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
