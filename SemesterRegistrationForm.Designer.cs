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
            PayButton.Location = new Point(337, 172);
            PayButton.Margin = new Padding(2);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(153, 51);
            PayButton.TabIndex = 0;
            PayButton.Text = "ثبت نام";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // StudentNumCB
            // 
            StudentNumCB.FormattingEnabled = true;
            StudentNumCB.Location = new Point(302, 49);
            StudentNumCB.Margin = new Padding(2);
            StudentNumCB.Name = "StudentNumCB";
            StudentNumCB.Size = new Size(207, 27);
            StudentNumCB.TabIndex = 1;
            StudentNumCB.SelectedIndexChanged += StudentNumCB_SelectedIndexChanged;
            StudentNumCB.SelectionChangeCommitted += StudentNumCB_SelectionChangeCommitted;
            // 
            // UserNLabel
            // 
            UserNLabel.AutoSize = true;
            UserNLabel.Location = new Point(290, 21);
            UserNLabel.Margin = new Padding(2, 0, 2, 0);
            UserNLabel.Name = "UserNLabel";
            UserNLabel.Size = new Size(220, 19);
            UserNLabel.TabIndex = 2;
            UserNLabel.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // TermLabel
            // 
            TermLabel.AutoSize = true;
            TermLabel.Location = new Point(337, 97);
            TermLabel.Margin = new Padding(2, 0, 2, 0);
            TermLabel.Name = "TermLabel";
            TermLabel.Size = new Size(169, 19);
            TermLabel.TabIndex = 3;
            TermLabel.Text = "ترم مورد نظر را انتخاب کنید";
            // 
            // TermComboB
            // 
            TermComboB.FormattingEnabled = true;
            TermComboB.Location = new Point(302, 125);
            TermComboB.Margin = new Padding(2);
            TermComboB.Name = "TermComboB";
            TermComboB.Size = new Size(207, 27);
            TermComboB.TabIndex = 4;
            TermComboB.SelectedIndexChanged += TermComboB_SelectedIndexChanged;
            // 
            // GoToUCPButton
            // 
            GoToUCPButton.ForeColor = Color.Red;
            GoToUCPButton.Location = new Point(337, 246);
            GoToUCPButton.Margin = new Padding(2);
            GoToUCPButton.Name = "GoToUCPButton";
            GoToUCPButton.Size = new Size(153, 51);
            GoToUCPButton.TabIndex = 5;
            GoToUCPButton.Text = "بازگشت به پنل کاربری";
            GoToUCPButton.UseVisualStyleBackColor = true;
            GoToUCPButton.Click += GoToUCPButton_Click;
            // 
            // infolabel
            // 
            infolabel.AutoSize = true;
            infolabel.Location = new Point(135, 21);
            infolabel.Margin = new Padding(2, 0, 2, 0);
            infolabel.MaximumSize = new Size(272, 0);
            infolabel.Name = "infolabel";
            infolabel.RightToLeft = RightToLeft.Yes;
            infolabel.Size = new Size(0, 19);
            infolabel.TabIndex = 6;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Location = new Point(12, 105);
            BalanceLabel.Margin = new Padding(2, 0, 2, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.RightToLeft = RightToLeft.Yes;
            BalanceLabel.Size = new Size(0, 19);
            BalanceLabel.TabIndex = 7;
            // 
            // GoToPayPButton
            // 
            GoToPayPButton.ForeColor = Color.Olive;
            GoToPayPButton.Location = new Point(19, 222);
            GoToPayPButton.Margin = new Padding(2);
            GoToPayPButton.Name = "GoToPayPButton";
            GoToPayPButton.Size = new Size(222, 51);
            GoToPayPButton.TabIndex = 8;
            GoToPayPButton.Text = "افزایش موجودی";
            GoToPayPButton.UseVisualStyleBackColor = true;
            GoToPayPButton.Click += GoToPayPButton_Click;
            // 
            // GoToPayLButton
            // 
            GoToPayLButton.ForeColor = Color.ForestGreen;
            GoToPayLButton.Location = new Point(19, 277);
            GoToPayLButton.Margin = new Padding(2);
            GoToPayLButton.Name = "GoToPayLButton";
            GoToPayLButton.Size = new Size(222, 51);
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
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(276, 336);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات حساب کاربری";
            // 
            // button1
            // 
            button1.Location = new Point(19, 182);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(222, 36);
            button1.TabIndex = 11;
            button1.Text = "به روزرسانی مشخصات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Location = new Point(26, 134);
            pricelabel.Margin = new Padding(2, 0, 2, 0);
            pricelabel.Name = "pricelabel";
            pricelabel.RightToLeft = RightToLeft.Yes;
            pricelabel.Size = new Size(0, 19);
            pricelabel.TabIndex = 10;
            // 
            // SemesterRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 350);
            Controls.Add(groupBox1);
            Controls.Add(GoToUCPButton);
            Controls.Add(TermComboB);
            Controls.Add(TermLabel);
            Controls.Add(UserNLabel);
            Controls.Add(StudentNumCB);
            Controls.Add(PayButton);
            Margin = new Padding(2);
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