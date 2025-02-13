namespace razorshark2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            BetUp = new Button();
            BetDown = new Button();
            bet = new Label();
            balance = new Label();
            slot1 = new PictureBox();
            slot2 = new PictureBox();
            slot3 = new PictureBox();
            slot4 = new PictureBox();
            slot8 = new PictureBox();
            slot7 = new PictureBox();
            slot6 = new PictureBox();
            slot5 = new PictureBox();
            slot12 = new PictureBox();
            slot11 = new PictureBox();
            slot10 = new PictureBox();
            slot9 = new PictureBox();
            winnings = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot9).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(950, 559);
            button1.Name = "button1";
            button1.Size = new Size(99, 73);
            button1.TabIndex = 1;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BetUp
            // 
            BetUp.BackColor = Color.Transparent;
            BetUp.FlatStyle = FlatStyle.Popup;
            BetUp.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BetUp.Location = new Point(605, 559);
            BetUp.Name = "BetUp";
            BetUp.Size = new Size(38, 38);
            BetUp.TabIndex = 2;
            BetUp.Text = "+";
            BetUp.UseVisualStyleBackColor = false;
            BetUp.Click += BetUp_Click;
            // 
            // BetDown
            // 
            BetDown.BackColor = Color.Transparent;
            BetDown.FlatStyle = FlatStyle.Popup;
            BetDown.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BetDown.Location = new Point(605, 594);
            BetDown.Name = "BetDown";
            BetDown.Size = new Size(38, 38);
            BetDown.TabIndex = 3;
            BetDown.Text = "-";
            BetDown.UseVisualStyleBackColor = false;
            BetDown.Click += BetDown_Click;
            // 
            // bet
            // 
            bet.AutoSize = true;
            bet.BackColor = Color.Transparent;
            bet.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bet.ForeColor = SystemColors.ButtonHighlight;
            bet.Location = new Point(420, 590);
            bet.Name = "bet";
            bet.Size = new Size(68, 40);
            bet.TabIndex = 4;
            bet.Text = "10$";
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.BackColor = Color.Transparent;
            balance.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balance.ForeColor = SystemColors.ButtonHighlight;
            balance.Location = new Point(200, 590);
            balance.Name = "balance";
            balance.Size = new Size(102, 40);
            balance.TabIndex = 5;
            balance.Text = "1000$";
            // 
            // slot1
            // 
            slot1.BackgroundImage = (Image)resources.GetObject("slot1.BackgroundImage");
            slot1.Location = new Point(247, 65);
            slot1.Name = "slot1";
            slot1.Size = new Size(154, 156);
            slot1.TabIndex = 6;
            slot1.TabStop = false;
            // 
            // slot2
            // 
            slot2.BackgroundImage = (Image)resources.GetObject("slot2.BackgroundImage");
            slot2.Location = new Point(402, 65);
            slot2.Name = "slot2";
            slot2.Size = new Size(154, 156);
            slot2.TabIndex = 7;
            slot2.TabStop = false;
            // 
            // slot3
            // 
            slot3.BackgroundImage = Properties.Resources.Kamera;
            slot3.Location = new Point(557, 65);
            slot3.Name = "slot3";
            slot3.Size = new Size(154, 156);
            slot3.TabIndex = 8;
            slot3.TabStop = false;
            // 
            // slot4
            // 
            slot4.BackgroundImage = (Image)resources.GetObject("slot4.BackgroundImage");
            slot4.Location = new Point(712, 65);
            slot4.Name = "slot4";
            slot4.Size = new Size(154, 156);
            slot4.TabIndex = 9;
            slot4.TabStop = false;
            // 
            // slot8
            // 
            slot8.BackgroundImage = (Image)resources.GetObject("slot8.BackgroundImage");
            slot8.Location = new Point(713, 226);
            slot8.Name = "slot8";
            slot8.Size = new Size(154, 156);
            slot8.TabIndex = 13;
            slot8.TabStop = false;
            // 
            // slot7
            // 
            slot7.BackgroundImage = (Image)resources.GetObject("slot7.BackgroundImage");
            slot7.Location = new Point(558, 226);
            slot7.Name = "slot7";
            slot7.Size = new Size(154, 156);
            slot7.TabIndex = 12;
            slot7.TabStop = false;
            // 
            // slot6
            // 
            slot6.BackgroundImage = (Image)resources.GetObject("slot6.BackgroundImage");
            slot6.Location = new Point(403, 226);
            slot6.Name = "slot6";
            slot6.Size = new Size(154, 156);
            slot6.TabIndex = 11;
            slot6.TabStop = false;
            // 
            // slot5
            // 
            slot5.BackgroundImage = (Image)resources.GetObject("slot5.BackgroundImage");
            slot5.Location = new Point(248, 226);
            slot5.Name = "slot5";
            slot5.Size = new Size(154, 156);
            slot5.TabIndex = 10;
            slot5.TabStop = false;
            // 
            // slot12
            // 
            slot12.BackgroundImage = (Image)resources.GetObject("slot12.BackgroundImage");
            slot12.Location = new Point(713, 387);
            slot12.Name = "slot12";
            slot12.Size = new Size(154, 156);
            slot12.TabIndex = 17;
            slot12.TabStop = false;
            // 
            // slot11
            // 
            slot11.BackgroundImage = (Image)resources.GetObject("slot11.BackgroundImage");
            slot11.Location = new Point(558, 387);
            slot11.Name = "slot11";
            slot11.Size = new Size(154, 156);
            slot11.TabIndex = 16;
            slot11.TabStop = false;
            // 
            // slot10
            // 
            slot10.BackgroundImage = (Image)resources.GetObject("slot10.BackgroundImage");
            slot10.Location = new Point(403, 387);
            slot10.Name = "slot10";
            slot10.Size = new Size(154, 156);
            slot10.TabIndex = 15;
            slot10.TabStop = false;
            // 
            // slot9
            // 
            slot9.BackgroundImage = (Image)resources.GetObject("slot9.BackgroundImage");
            slot9.Location = new Point(248, 387);
            slot9.Name = "slot9";
            slot9.Size = new Size(154, 156);
            slot9.TabIndex = 14;
            slot9.TabStop = false;
            // 
            // winnings
            // 
            winnings.AutoSize = true;
            winnings.BackColor = Color.Transparent;
            winnings.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winnings.ForeColor = SystemColors.ButtonHighlight;
            winnings.Location = new Point(643, 590);
            winnings.Name = "winnings";
            winnings.Size = new Size(0, 40);
            winnings.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(408, 213);
            label1.Name = "label1";
            label1.Size = new Size(0, 128);
            label1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1137, 649);
            Controls.Add(label1);
            Controls.Add(winnings);
            Controls.Add(slot12);
            Controls.Add(slot11);
            Controls.Add(slot10);
            Controls.Add(slot9);
            Controls.Add(slot8);
            Controls.Add(slot7);
            Controls.Add(slot6);
            Controls.Add(slot5);
            Controls.Add(slot4);
            Controls.Add(slot3);
            Controls.Add(slot2);
            Controls.Add(slot1);
            Controls.Add(balance);
            Controls.Add(bet);
            Controls.Add(BetDown);
            Controls.Add(BetUp);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot4).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot8).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot7).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot6).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot5).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot12).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot11).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot10).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button BetUp;
        private Button BetDown;
        private Label bet;
        private Label balance;
        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private PictureBox slot4;
        private PictureBox slot8;
        private PictureBox slot7;
        private PictureBox slot6;
        private PictureBox slot5;
        private PictureBox slot12;
        private PictureBox slot11;
        private PictureBox slot10;
        private PictureBox slot9;
        private Label winnings;
        private Label label1;
    }
}
