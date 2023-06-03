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
            ChoosingLessonButton = new Button();
            LessonsLog = new Button();
            SuspendLayout();
            // 
            // TuitionPannelButton
            // 
            TuitionPannelButton.ForeColor = Color.FromArgb(0, 192, 0);
            TuitionPannelButton.Location = new Point(579, 89);
            TuitionPannelButton.Margin = new Padding(4);
            TuitionPannelButton.Name = "TuitionPannelButton";
            TuitionPannelButton.Size = new Size(252, 80);
            TuitionPannelButton.TabIndex = 3;
            TuitionPannelButton.Text = "ثبت نام ترم";
            TuitionPannelButton.UseVisualStyleBackColor = true;
            TuitionPannelButton.Click += TuitionPannelButton_Click;
            // 
            // WalletButton
            // 
            WalletButton.ForeColor = Color.FromArgb(0, 0, 192);
            WalletButton.Location = new Point(12, 89);
            WalletButton.Margin = new Padding(4);
            WalletButton.Name = "WalletButton";
            WalletButton.Size = new Size(260, 84);
            WalletButton.TabIndex = 5;
            WalletButton.Text = "شارژحساب دانشجویی";
            WalletButton.UseVisualStyleBackColor = true;
            WalletButton.Click += WalletButton_Click;
            // 
            // TuitionLogButton
            // 
            TuitionLogButton.ForeColor = Color.FromArgb(0, 192, 0);
            TuitionLogButton.Location = new Point(579, 199);
            TuitionLogButton.Margin = new Padding(4);
            TuitionLogButton.Name = "TuitionLogButton";
            TuitionLogButton.Size = new Size(252, 80);
            TuitionLogButton.TabIndex = 6;
            TuitionLogButton.Text = "تاریخچه ثبت نام ترم";
            TuitionLogButton.UseVisualStyleBackColor = true;
            TuitionLogButton.Click += TuitionLogButton_Click;
            // 
            // WalletPaymentsLogButton
            // 
            WalletPaymentsLogButton.ForeColor = Color.FromArgb(0, 0, 192);
            WalletPaymentsLogButton.Location = new Point(12, 199);
            WalletPaymentsLogButton.Margin = new Padding(4);
            WalletPaymentsLogButton.Name = "WalletPaymentsLogButton";
            WalletPaymentsLogButton.Size = new Size(261, 80);
            WalletPaymentsLogButton.TabIndex = 8;
            WalletPaymentsLogButton.Text = "تاریخچه شارژحساب";
            WalletPaymentsLogButton.UseVisualStyleBackColor = true;
            WalletPaymentsLogButton.Click += WalletPaymentsLogButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.ForeColor = Color.Red;
            ExitButton.Location = new Point(315, 309);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(210, 80);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "خروج از برنامه";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(329, 22);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 31);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(57, 25);
            label1.TabIndex = 12;
            label1.Text = "کاربر :";
            // 
            // ChoosingLessonButton
            // 
            ChoosingLessonButton.ForeColor = Color.Black;
            ChoosingLessonButton.Location = new Point(300, 91);
            ChoosingLessonButton.Margin = new Padding(4);
            ChoosingLessonButton.Name = "ChoosingLessonButton";
            ChoosingLessonButton.Size = new Size(252, 80);
            ChoosingLessonButton.TabIndex = 13;
            ChoosingLessonButton.Text = "انتخاب واحد";
            ChoosingLessonButton.UseVisualStyleBackColor = true;
            ChoosingLessonButton.Click += ChoosingLessonButton_Click;
            // 
            // LessonsLog
            // 
            LessonsLog.ForeColor = Color.Black;
            LessonsLog.Location = new Point(300, 199);
            LessonsLog.Margin = new Padding(4);
            LessonsLog.Name = "LessonsLog";
            LessonsLog.Size = new Size(252, 80);
            LessonsLog.TabIndex = 14;
            LessonsLog.Text = "تاریخچه انتخاب واحد";
            LessonsLog.UseVisualStyleBackColor = true;
            // 
            // Userpannel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 438);
            Controls.Add(LessonsLog);
            Controls.Add(ChoosingLessonButton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ExitButton);
            Controls.Add(WalletPaymentsLogButton);
            Controls.Add(TuitionLogButton);
            Controls.Add(WalletButton);
            Controls.Add(TuitionPannelButton);
            Margin = new Padding(2, 3, 2, 3);
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
        private Button ChoosingLessonButton;
        private Button LessonsLog;
    }
}