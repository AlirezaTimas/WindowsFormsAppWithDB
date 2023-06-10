namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class LessonChoosingForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            genderllabel = new Label();
            fathernlabel = new Label();
            namelabel = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            Submitbutton = new Button();
            LessonLogButton = new Button();
            GotoUPButton = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Studentnumcombobox
            // 
            Studentnumcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Studentnumcombobox.FormattingEnabled = true;
            Studentnumcombobox.Location = new Point(867, 113);
            Studentnumcombobox.Name = "Studentnumcombobox";
            Studentnumcombobox.RightToLeft = RightToLeft.Yes;
            Studentnumcombobox.Size = new Size(267, 33);
            Studentnumcombobox.TabIndex = 0;
            Studentnumcombobox.SelectedIndexChanged += Studentnumcombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(853, 67);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 1;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(genderllabel);
            groupBox1.Controls.Add(fathernlabel);
            groupBox1.Controls.Add(namelabel);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(621, 550);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فردی دانشجو";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 227);
            label6.Name = "label6";
            label6.Size = new Size(402, 25);
            label6.TabIndex = 9;
            label6.Text = "دروس انتخاب شده توسط این دانشجو در ترم کنونی : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 185);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 123);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 80);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 5;
            label2.TextChanged += label2_TextChanged;
            // 
            // genderllabel
            // 
            genderllabel.AutoSize = true;
            genderllabel.Location = new Point(533, 123);
            genderllabel.Name = "genderllabel";
            genderllabel.Size = new Size(81, 25);
            genderllabel.TabIndex = 3;
            genderllabel.Text = "جنسیت : ";
            // 
            // fathernlabel
            // 
            fathernlabel.AutoSize = true;
            fathernlabel.Location = new Point(543, 80);
            fathernlabel.Name = "fathernlabel";
            fathernlabel.Size = new Size(71, 25);
            fathernlabel.TabIndex = 2;
            fathernlabel.Text = "نام پدر :";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(451, 36);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(163, 25);
            namelabel.TabIndex = 1;
            namelabel.Text = "نام و نام خانوادگی : ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(6, 265);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(608, 279);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 1000;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(662, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(472, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(662, 274);
            label7.MaximumSize = new Size(472, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(0, 25);
            label7.TabIndex = 4;
            // 
            // Submitbutton
            // 
            Submitbutton.ForeColor = Color.Blue;
            Submitbutton.Location = new Point(904, 417);
            Submitbutton.Name = "Submitbutton";
            Submitbutton.Size = new Size(236, 64);
            Submitbutton.TabIndex = 10;
            Submitbutton.Text = "تثبیت واحد";
            Submitbutton.UseVisualStyleBackColor = true;
            Submitbutton.Click += Submitbutton_Click;
            // 
            // LessonLogButton
            // 
            LessonLogButton.ForeColor = Color.Olive;
            LessonLogButton.Location = new Point(662, 417);
            LessonLogButton.Name = "LessonLogButton";
            LessonLogButton.Size = new Size(236, 64);
            LessonLogButton.TabIndex = 11;
            LessonLogButton.Text = "لیست واحد های دانشجو";
            LessonLogButton.UseVisualStyleBackColor = true;
            LessonLogButton.Click += LessonLogButton_Click;
            // 
            // GotoUPButton
            // 
            GotoUPButton.ForeColor = Color.Red;
            GotoUPButton.Location = new Point(776, 487);
            GotoUPButton.Name = "GotoUPButton";
            GotoUPButton.Size = new Size(236, 64);
            GotoUPButton.TabIndex = 12;
            GotoUPButton.Text = "بازگشت به پنل کاربری";
            GotoUPButton.UseVisualStyleBackColor = true;
            GotoUPButton.Click += GotoUPButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(872, 179);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(262, 25);
            label8.TabIndex = 13;
            label8.Text = "درس مورد نظر خود را انتخاب کنید";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(662, 378);
            label9.MaximumSize = new Size(472, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(0, 25);
            label9.TabIndex = 14;
            // 
            // LessonChoosingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 571);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(GotoUPButton);
            Controls.Add(Submitbutton);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(LessonLogButton);
            Controls.Add(Studentnumcombobox);
            Controls.Add(comboBox1);
            Name = "LessonChoosingForm";
            Text = "فرم انتخاب واحد";
            FormClosing += LessonChoosingForm_FormClosing;
            Load += LessonChoosingForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Studentnumcombobox;
        private Label label1;
        private GroupBox groupBox1;
        private Label namelabel;
        private ListBox listBox1;
        private Label genderllabel;
        private Label fathernlabel;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Button Submitbutton;
        private Button LessonLogButton;
        private Button GotoUPButton;
        private Label label8;
        private Label label9;
    }
}