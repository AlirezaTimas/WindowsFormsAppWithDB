namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class PaymentLogForm
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
            Loglistbox = new ListBox();
            label1 = new Label();
            Studentnumcombobox = new ComboBox();
            GoToUserPannelButton = new Button();
            GoToBalanceFormButton = new Button();
            SuspendLayout();
            // 
            // Loglistbox
            // 
            Loglistbox.FormattingEnabled = true;
            Loglistbox.ItemHeight = 25;
            Loglistbox.Location = new Point(12, 12);
            Loglistbox.Name = "Loglistbox";
            Loglistbox.RightToLeft = RightToLeft.Yes;
            Loglistbox.Size = new Size(669, 504);
            Loglistbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 135);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(281, 25);
            label1.TabIndex = 1;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // Studentnumcombobox
            // 
            Studentnumcombobox.FormattingEnabled = true;
            Studentnumcombobox.Location = new Point(703, 182);
            Studentnumcombobox.Name = "Studentnumcombobox";
            Studentnumcombobox.Size = new Size(281, 33);
            Studentnumcombobox.TabIndex = 2;
            Studentnumcombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // GoToUserPannelButton
            // 
            GoToUserPannelButton.ForeColor = Color.Red;
            GoToUserPannelButton.Location = new Point(746, 290);
            GoToUserPannelButton.Name = "GoToUserPannelButton";
            GoToUserPannelButton.Size = new Size(196, 70);
            GoToUserPannelButton.TabIndex = 3;
            GoToUserPannelButton.Text = "بازگشت به پنل کاربری";
            GoToUserPannelButton.UseVisualStyleBackColor = true;
            GoToUserPannelButton.Click += GoToUserPannelButton_Click;
            // 
            // GoToBalanceFormButton
            // 
            GoToBalanceFormButton.ForeColor = Color.Blue;
            GoToBalanceFormButton.Location = new Point(746, 386);
            GoToBalanceFormButton.Name = "GoToBalanceFormButton";
            GoToBalanceFormButton.Size = new Size(196, 70);
            GoToBalanceFormButton.TabIndex = 4;
            GoToBalanceFormButton.Text = "افزایش موجودی حساب";
            GoToBalanceFormButton.UseVisualStyleBackColor = true;
            GoToBalanceFormButton.Click += GoToBalanceFormButton_Click;
            // 
            // PaymentLogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 529);
            Controls.Add(GoToBalanceFormButton);
            Controls.Add(GoToUserPannelButton);
            Controls.Add(Studentnumcombobox);
            Controls.Add(label1);
            Controls.Add(Loglistbox);
            Name = "PaymentLogForm";
            Text = "تاریخچه پرداخت";
            FormClosing += PaymentLogForm_FormClosing;
            Load += PaymentLogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Loglistbox;
        private Label label1;
        private ComboBox Studentnumcombobox;
        private Button GoToUserPannelButton;
        private Button GoToBalanceFormButton;
    }
}