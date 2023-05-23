namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class SemesterRegistrationLogForm
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
            label1 = new Label();
            StudentnumCB = new ComboBox();
            loglistbox = new ListBox();
            GoToPayFormButton = new Button();
            GoToUserPannelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 19);
            label1.TabIndex = 0;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // StudentnumCB
            // 
            StudentnumCB.FormattingEnabled = true;
            StudentnumCB.Location = new Point(518, 138);
            StudentnumCB.Margin = new Padding(2, 2, 2, 2);
            StudentnumCB.Name = "StudentnumCB";
            StudentnumCB.Size = new Size(219, 27);
            StudentnumCB.TabIndex = 1;
            StudentnumCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // loglistbox
            // 
            loglistbox.FormattingEnabled = true;
            loglistbox.HorizontalScrollbar = true;
            loglistbox.ItemHeight = 19;
            loglistbox.Location = new Point(10, 9);
            loglistbox.Margin = new Padding(2, 2, 2, 2);
            loglistbox.Name = "loglistbox";
            loglistbox.RightToLeft = RightToLeft.Yes;
            loglistbox.Size = new Size(496, 403);
            loglistbox.TabIndex = 2;
            // 
            // GoToPayFormButton
            // 
            GoToPayFormButton.ForeColor = Color.ForestGreen;
            GoToPayFormButton.Location = new Point(543, 210);
            GoToPayFormButton.Margin = new Padding(2, 2, 2, 2);
            GoToPayFormButton.Name = "GoToPayFormButton";
            GoToPayFormButton.Size = new Size(171, 58);
            GoToPayFormButton.TabIndex = 3;
            GoToPayFormButton.Text = "صفحه ثبت نام";
            GoToPayFormButton.UseVisualStyleBackColor = true;
            GoToPayFormButton.Click += GoToPayFormButton_Click;
            // 
            // GoToUserPannelButton
            // 
            GoToUserPannelButton.ForeColor = Color.Red;
            GoToUserPannelButton.Location = new Point(543, 289);
            GoToUserPannelButton.Margin = new Padding(2, 2, 2, 2);
            GoToUserPannelButton.Name = "GoToUserPannelButton";
            GoToUserPannelButton.Size = new Size(171, 56);
            GoToUserPannelButton.TabIndex = 4;
            GoToUserPannelButton.Text = "بازگشت به پنل کاربری";
            GoToUserPannelButton.UseVisualStyleBackColor = true;
            GoToUserPannelButton.Click += GoToUserPannelButton_Click;
            // 
            // SemesterRegistrationLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 420);
            Controls.Add(GoToUserPannelButton);
            Controls.Add(GoToPayFormButton);
            Controls.Add(loglistbox);
            Controls.Add(StudentnumCB);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SemesterRegistrationLogForm";
            Text = "تاریخچه ثبت نام ترمی";
            FormClosing += SemesterRegistrationLogForm_FormClosing;
            Load += SemesterRegisterationLogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox StudentnumCB;
        private ListBox loglistbox;
        private Button GoToPayFormButton;
        private Button GoToUserPannelButton;
    }
}