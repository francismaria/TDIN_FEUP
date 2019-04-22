namespace DiningRoomTerminal
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
            this.foodBtn = new System.Windows.Forms.Button();
            this.drinksBtn = new System.Windows.Forms.Button();
            this.drinksChoiceControl1 = new DiningRoomTerminal.DrinksChoiceControl();
            this.SuspendLayout();
            // 
            // foodBtn
            // 
            this.foodBtn.Location = new System.Drawing.Point(367, 484);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(275, 129);
            this.foodBtn.TabIndex = 1;
            this.foodBtn.Text = "Food";
            this.foodBtn.UseVisualStyleBackColor = true;
            this.foodBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // drinksBtn
            // 
            this.drinksBtn.Location = new System.Drawing.Point(1089, 484);
            this.drinksBtn.Name = "drinksBtn";
            this.drinksBtn.Size = new System.Drawing.Size(275, 129);
            this.drinksBtn.TabIndex = 2;
            this.drinksBtn.Text = "Drinks";
            this.drinksBtn.UseVisualStyleBackColor = true;
            this.drinksBtn.Click += new System.EventHandler(this.DrinksBtn_Click);
            // 
            // drinksChoiceControl1
            // 
            this.drinksChoiceControl1.Location = new System.Drawing.Point(0, -3);
            this.drinksChoiceControl1.Name = "drinksChoiceControl1";
            this.drinksChoiceControl1.Size = new System.Drawing.Size(1744, 1206);
            this.drinksChoiceControl1.TabIndex = 3;
            this.drinksChoiceControl1.Load += new System.EventHandler(this.DrinksChoiceControl1_Load);
            // 
            // NewOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drinksChoiceControl1);
            this.Controls.Add(this.drinksBtn);
            this.Controls.Add(this.foodBtn);
            this.Name = "NewOrderControl";
            this.Size = new System.Drawing.Size(1744, 1206);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button foodBtn;
        private System.Windows.Forms.Button drinksBtn;
        private DrinksChoiceControl drinksChoiceControl1;
    }
}
