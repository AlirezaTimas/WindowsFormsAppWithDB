namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class BalanceIncreaseFrom
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
            Studentnumcombobox = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AmountTextBox = new TextBox();
            PayButton = new Button();
            PayLogButton = new Button();
            GoToPayFormButton = new Button();
            GoToUserPannelButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Studentnumcombobox
            // 
            Studentnumcombobox.FormattingEnabled = true;
            Studentnumcombobox.Location = new Point(288, 59);
            Studentnumcombobox.Name = "Studentnumcombobox";
            Studentnumcombobox.Size = new Size(162, 27);
            Studentnumcombobox.TabIndex = 0;
            Studentnumcombobox.SelectedIndexChanged += Studentnumcombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 30);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(220, 19);
            label1.TabIndex = 1;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 209);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات حساب";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 150);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(0, 19);
            label10.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(109, 112);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(0, 19);
            label9.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 73);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(0, 19);
            label8.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 38);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(0, 19);
            label7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 150);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(109, 19);
            label6.TabIndex = 3;
            label6.Text = "موجودی حساب : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 112);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(63, 19);
            label5.TabIndex = 2;
            label5.Text = "جنسیت : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 73);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(55, 19);
            label4.TabIndex = 1;
            label4.Text = "نام پدر :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(84, 19);
            label3.TabIndex = 0;
            label3.Text = "نام دانشجو : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 109);
            label2.Name = "label2";
            label2.Size = new Size(148, 19);
            label2.TabIndex = 3;
            label2.Text = "مبلغ را وارد کنید (تومان)";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(288, 138);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(162, 26);
            AmountTextBox.TabIndex = 4;
            AmountTextBox.KeyPress += AmountTextBox_KeyPress;
            // 
            // PayButton
            // 
            PayButton.ForeColor = Color.Blue;
            PayButton.Location = new Point(280, 227);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(170, 50);
            PayButton.TabIndex = 5;
            PayButton.Text = "افزایش موجودی";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // PayLogButton
            // 
            PayLogButton.ForeColor = Color.Blue;
            PayLogButton.Location = new Point(280, 292);
            PayLogButton.Name = "PayLogButton";
            PayLogButton.Size = new Size(170, 49);
            PayLogButton.TabIndex = 6;
            PayLogButton.Text = "تاریخچه شارژ حساب";
            PayLogButton.UseVisualStyleBackColor = true;
            PayLogButton.Click += PayLogButton_Click;
            // 
            // GoToPayFormButton
            // 
            GoToPayFormButton.ForeColor = Color.Olive;
            GoToPayFormButton.Location = new Point(43, 227);
            GoToPayFormButton.Name = "GoToPayFormButton";
            GoToPayFormButton.Size = new Size(162, 49);
            GoToPayFormButton.TabIndex = 7;
            GoToPayFormButton.Text = "صفحه ثبت نام";
            GoToPayFormButton.UseVisualStyleBackColor = true;
            GoToPayFormButton.Click += GoToPayFormButton_Click;
            // 
            // GoToUserPannelButton
            // 
            GoToUserPannelButton.ForeColor = Color.Red;
            GoToUserPannelButton.Location = new Point(43, 292);
            GoToUserPannelButton.Name = "GoToUserPannelButton";
            GoToUserPannelButton.Size = new Size(162, 49);
            GoToUserPannelButton.TabIndex = 8;
            GoToUserPannelButton.Text = "بازگشت به پنل کاربری";
            GoToUserPannelButton.UseVisualStyleBackColor = true;
            GoToUserPannelButton.Click += GoToUserPannelButton_Click;
            // 
            // BalanceIncreaseFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 370);
            Controls.Add(label2);
            Controls.Add(GoToUserPannelButton);
            Controls.Add(GoToPayFormButton);
            Controls.Add(PayLogButton);
            Controls.Add(PayButton);
            Controls.Add(AmountTextBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Studentnumcombobox);
            Name = "BalanceIncreaseFrom";
            Text = "پنل افزایش موجودی";
            FormClosing += BalanceIncreaseFrom_FormClosing;
            Load += BalanceIncreaseFrom_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Studentnumcombobox;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox AmountTextBox;
        private Button PayButton;
        private Button PayLogButton;
        private Button GoToPayFormButton;
        private Button GoToUserPannelButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}