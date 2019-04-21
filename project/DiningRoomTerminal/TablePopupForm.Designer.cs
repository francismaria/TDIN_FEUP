namespace DiningRoomTerminal
{
    partial class TablePopupForm
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
            this.OpenTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeTableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenTable
            // 
            this.OpenTable.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OpenTable.Location = new System.Drawing.Point(297, 306);
            this.OpenTable.Name = "OpenTable";
            this.OpenTable.Size = new System.Drawing.Size(327, 101);
            this.OpenTable.TabIndex = 1;
            this.OpenTable.Text = "Open Table";
            this.OpenTable.UseVisualStyleBackColor = true;
            this.OpenTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you like top open table # X?";
            // 
            // closeTableBtn
            // 
            this.closeTableBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeTableBtn.Location = new System.Drawing.Point(297, 306);
            this.closeTableBtn.Name = "closeTableBtn";
            this.closeTableBtn.Size = new System.Drawing.Size(327, 101);
            this.closeTableBtn.TabIndex = 3;
            this.closeTableBtn.Text = "Close Table";
            this.closeTableBtn.UseVisualStyleBackColor = true;
            // 
            // TablePopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 510);
            this.Controls.Add(this.closeTableBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenTable);
            this.Name = "TablePopupForm";
            this.Text = "TablePopupForm";
            this.Load += new System.EventHandler(this.TablePopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeTableBtn;
    }
}