namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class Userpannel
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
            TuitionPannelButton = new Button();
            WalletButton = new Button();
            TuitionLogButton = new Button();
            WalletPaymentsLogButton = new Button();
            ExitButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // TuitionPannelButton
            // 
            TuitionPannelButton.ForeColor = Color.FromArgb(0, 192, 0);
            TuitionPannelButton.Location = new Point(268, 71);
            TuitionPannelButton.Name = "TuitionPannelButton";
            TuitionPannelButton.Size = new Size(202, 61);
            TuitionPannelButton.TabIndex = 3;
            TuitionPannelButton.Text = "ثبت نام ترم";
            TuitionPannelButton.UseVisualStyleBackColor = true;
            TuitionPannelButton.Click += TuitionPannelButton_Click;
            // 
            // WalletButton
            // 
            WalletButton.ForeColor = Color.FromArgb(0, 0, 192);
            WalletButton.Location = new Point(10, 68);
            WalletButton.Name = "WalletButton";
            WalletButton.Size = new Size(208, 64);
            WalletButton.TabIndex = 5;
            WalletButton.Text = "شارژحساب دانشجویی";
            WalletButton.UseVisualStyleBackColor = true;
            WalletButton.Click += WalletButton_Click;
            // 
            // TuitionLogButton
            // 
            TuitionLogButton.ForeColor = Color.FromArgb(0, 192, 0);
            TuitionLogButton.Location = new Point(268, 151);
            TuitionLogButton.Name = "TuitionLogButton";
            TuitionLogButton.Size = new Size(202, 61);
            TuitionLogButton.TabIndex = 6;
            TuitionLogButton.Text = "تاریخچه ثبت نام ترم";
            TuitionLogButton.UseVisualStyleBackColor = true;
            TuitionLogButton.Click += TuitionLogButton_Click;
            // 
            // WalletPaymentsLogButton
            // 
            WalletPaymentsLogButton.ForeColor = Color.FromArgb(0, 0, 192);
            WalletPaymentsLogButton.Location = new Point(10, 151);
            WalletPaymentsLogButton.Name = "WalletPaymentsLogButton";
            WalletPaymentsLogButton.Size = new Size(209, 61);
            WalletPaymentsLogButton.TabIndex = 8;
            WalletPaymentsLogButton.Text = "تاریخچه شارژحساب";
            WalletPaymentsLogButton.UseVisualStyleBackColor = true;
            WalletPaymentsLogButton.Click += WalletPaymentsLogButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.ForeColor = Color.Red;
            ExitButton.Location = new Point(155, 244);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(168, 61);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "خروج از برنامه";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(166, 17);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 26);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(44, 19);
            label1.TabIndex = 12;
            label1.Text = "کاربر :";
            // 
            // Userpannel
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 344);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ExitButton);
            Controls.Add(WalletPaymentsLogButton);
            Controls.Add(TuitionLogButton);
            Controls.Add(WalletButton);
            Controls.Add(TuitionPannelButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Userpannel";
            Text = "پنل کاربری";
            FormClosing += Userpannel_FormClosing;
            Load += Userpannel_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TuitionPannelButton;
        private Button WalletButton;
        private Button TuitionLogButton;
        private Button WalletPaymentsLogButton;
        private Button ExitButton;
        public TextBox textBox1;
        private Label label1;
    }
}