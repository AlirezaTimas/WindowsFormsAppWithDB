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
            label1.Location = new Point(640, 139);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 0;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // StudentnumCB
            // 
            StudentnumCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentnumCB.FormattingEnabled = true;
            StudentnumCB.Location = new Point(648, 182);
            StudentnumCB.Margin = new Padding(2, 3, 2, 3);
            StudentnumCB.Name = "StudentnumCB";
            StudentnumCB.Size = new Size(273, 33);
            StudentnumCB.TabIndex = 1;
            StudentnumCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // loglistbox
            // 
            loglistbox.FormattingEnabled = true;
            loglistbox.HorizontalScrollbar = true;
            loglistbox.ItemHeight = 25;
            loglistbox.Location = new Point(12, 12);
            loglistbox.Margin = new Padding(2, 3, 2, 3);
            loglistbox.Name = "loglistbox";
            loglistbox.RightToLeft = RightToLeft.Yes;
            loglistbox.Size = new Size(619, 529);
            loglistbox.TabIndex = 2;
            // 
            // GoToPayFormButton
            // 
            GoToPayFormButton.ForeColor = Color.ForestGreen;
            GoToPayFormButton.Location = new Point(679, 276);
            GoToPayFormButton.Margin = new Padding(2, 3, 2, 3);
            GoToPayFormButton.Name = "GoToPayFormButton";
            GoToPayFormButton.Size = new Size(214, 76);
            GoToPayFormButton.TabIndex = 3;
            GoToPayFormButton.Text = "صفحه ثبت نام";
            GoToPayFormButton.UseVisualStyleBackColor = true;
            GoToPayFormButton.Click += GoToPayFormButton_Click;
            // 
            // GoToUserPannelButton
            // 
            GoToUserPannelButton.ForeColor = Color.Red;
            GoToUserPannelButton.Location = new Point(679, 380);
            GoToUserPannelButton.Margin = new Padding(2, 3, 2, 3);
            GoToUserPannelButton.Name = "GoToUserPannelButton";
            GoToUserPannelButton.Size = new Size(214, 74);
            GoToUserPannelButton.TabIndex = 4;
            GoToUserPannelButton.Text = "بازگشت به پنل کاربری";
            GoToUserPannelButton.UseVisualStyleBackColor = true;
            GoToUserPannelButton.Click += GoToUserPannelButton_Click;
            // 
            // SemesterRegistrationLogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(GoToUserPannelButton);
            Controls.Add(GoToPayFormButton);
            Controls.Add(loglistbox);
            Controls.Add(StudentnumCB);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
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