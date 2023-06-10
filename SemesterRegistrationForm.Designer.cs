namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class SemesterRegistrationForm
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
            PayButton = new Button();
            StudentNumCB = new ComboBox();
            UserNLabel = new Label();
            TermLabel = new Label();
            TermComboB = new ComboBox();
            GoToUCPButton = new Button();
            infolabel = new Label();
            BalanceLabel = new Label();
            GoToPayPButton = new Button();
            GoToPayLButton = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            pricelabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PayButton
            // 
            PayButton.ForeColor = Color.Blue;
            PayButton.Location = new Point(421, 226);
            PayButton.Margin = new Padding(2, 3, 2, 3);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(191, 67);
            PayButton.TabIndex = 0;
            PayButton.Text = "ثبت نام";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // StudentNumCB
            // 
            StudentNumCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentNumCB.FormattingEnabled = true;
            StudentNumCB.Location = new Point(378, 64);
            StudentNumCB.Margin = new Padding(2, 3, 2, 3);
            StudentNumCB.Name = "StudentNumCB";
            StudentNumCB.Size = new Size(258, 33);
            StudentNumCB.TabIndex = 1;
            StudentNumCB.SelectedIndexChanged += StudentNumCB_SelectedIndexChanged;
            StudentNumCB.SelectionChangeCommitted += StudentNumCB_SelectionChangeCommitted;
            // 
            // UserNLabel
            // 
            UserNLabel.AutoSize = true;
            UserNLabel.Location = new Point(362, 28);
            UserNLabel.Margin = new Padding(2, 0, 2, 0);
            UserNLabel.Name = "UserNLabel";
            UserNLabel.Size = new Size(281, 25);
            UserNLabel.TabIndex = 2;
            UserNLabel.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // TermLabel
            // 
            TermLabel.AutoSize = true;
            TermLabel.Location = new Point(421, 128);
            TermLabel.Margin = new Padding(2, 0, 2, 0);
            TermLabel.Name = "TermLabel";
            TermLabel.Size = new Size(215, 25);
            TermLabel.TabIndex = 3;
            TermLabel.Text = "ترم مورد نظر را انتخاب کنید";
            // 
            // TermComboB
            // 
            TermComboB.DropDownStyle = ComboBoxStyle.DropDownList;
            TermComboB.FormattingEnabled = true;
            TermComboB.Location = new Point(378, 164);
            TermComboB.Margin = new Padding(2, 3, 2, 3);
            TermComboB.Name = "TermComboB";
            TermComboB.Size = new Size(258, 33);
            TermComboB.TabIndex = 4;
            TermComboB.SelectedIndexChanged += TermComboB_SelectedIndexChanged;
            // 
            // GoToUCPButton
            // 
            GoToUCPButton.ForeColor = Color.Red;
            GoToUCPButton.Location = new Point(421, 324);
            GoToUCPButton.Margin = new Padding(2, 3, 2, 3);
            GoToUCPButton.Name = "GoToUCPButton";
            GoToUCPButton.Size = new Size(191, 67);
            GoToUCPButton.TabIndex = 5;
            GoToUCPButton.Text = "بازگشت به پنل کاربری";
            GoToUCPButton.UseVisualStyleBackColor = true;
            GoToUCPButton.Click += GoToUCPButton_Click;
            // 
            // infolabel
            // 
            infolabel.AutoSize = true;
            infolabel.Location = new Point(169, 28);
            infolabel.Margin = new Padding(2, 0, 2, 0);
            infolabel.MaximumSize = new Size(340, 0);
            infolabel.Name = "infolabel";
            infolabel.RightToLeft = RightToLeft.Yes;
            infolabel.Size = new Size(0, 25);
            infolabel.TabIndex = 6;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Location = new Point(15, 138);
            BalanceLabel.Margin = new Padding(2, 0, 2, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.RightToLeft = RightToLeft.Yes;
            BalanceLabel.Size = new Size(0, 25);
            BalanceLabel.TabIndex = 7;
            // 
            // GoToPayPButton
            // 
            GoToPayPButton.ForeColor = Color.Olive;
            GoToPayPButton.Location = new Point(24, 292);
            GoToPayPButton.Margin = new Padding(2, 3, 2, 3);
            GoToPayPButton.Name = "GoToPayPButton";
            GoToPayPButton.Size = new Size(278, 67);
            GoToPayPButton.TabIndex = 8;
            GoToPayPButton.Text = "افزایش موجودی";
            GoToPayPButton.UseVisualStyleBackColor = true;
            GoToPayPButton.Click += GoToPayPButton_Click;
            // 
            // GoToPayLButton
            // 
            GoToPayLButton.ForeColor = Color.ForestGreen;
            GoToPayLButton.Location = new Point(24, 364);
            GoToPayLButton.Margin = new Padding(2, 3, 2, 3);
            GoToPayLButton.Name = "GoToPayLButton";
            GoToPayLButton.Size = new Size(278, 67);
            GoToPayLButton.TabIndex = 9;
            GoToPayLButton.Text = "تاریخچه ثبت نام ترمی";
            GoToPayLButton.UseVisualStyleBackColor = true;
            GoToPayLButton.Click += GoToPayLButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pricelabel);
            groupBox1.Controls.Add(GoToPayPButton);
            groupBox1.Controls.Add(BalanceLabel);
            groupBox1.Controls.Add(GoToPayLButton);
            groupBox1.Controls.Add(infolabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(345, 442);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات حساب کاربری";
            // 
            // button1
            // 
            button1.Location = new Point(24, 239);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(278, 47);
            button1.TabIndex = 11;
            button1.Text = "به روزرسانی مشخصات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Location = new Point(32, 176);
            pricelabel.Margin = new Padding(2, 0, 2, 0);
            pricelabel.Name = "pricelabel";
            pricelabel.RightToLeft = RightToLeft.Yes;
            pricelabel.Size = new Size(0, 25);
            pricelabel.TabIndex = 10;
            // 
            // SemesterRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 461);
            Controls.Add(groupBox1);
            Controls.Add(GoToUCPButton);
            Controls.Add(TermComboB);
            Controls.Add(TermLabel);
            Controls.Add(UserNLabel);
            Controls.Add(StudentNumCB);
            Controls.Add(PayButton);
            Margin = new Padding(2, 3, 2, 3);
            Name = "SemesterRegistrationForm";
            Text = "پنل ثبت نام";
            FormClosing += SemesterRegistrationForm_FormClosing;
            Load += TuitionPaymentPannel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PayButton;
        private ComboBox StudentNumCB;
        private Label UserNLabel;
        private Label TermLabel;
        private ComboBox TermComboB;
        private Button GoToUCPButton;
        private Label infolabel;
        private Label BalanceLabel;
        private Button GoToPayPButton;
        private Button GoToPayLButton;
        private GroupBox groupBox1;
        private Label pricelabel;
        private Button button1;
    }
}