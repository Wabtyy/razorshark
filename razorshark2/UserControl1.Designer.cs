namespace razorshark2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            amount = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount.ForeColor = Color.Aqua;
            amount.Location = new Point(47, 102);
            amount.Name = "amount";
            amount.Size = new Size(252, 79);
            amount.TabIndex = 0;
            amount.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(61, 13);
            label2.Name = "label2";
            label2.Size = new Size(169, 79);
            label2.TabIndex = 1;
            label2.Text = "WIN";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label2);
            Controls.Add(amount);
            Name = "UserControl1";
            Size = new Size(299, 207);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label amount;
        private Label label2;
    }
}
