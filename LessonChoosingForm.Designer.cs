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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Studentnumcombobox
            // 
            Studentnumcombobox.FormattingEnabled = true;
            Studentnumcombobox.Location = new Point(511, 84);
            Studentnumcombobox.Name = "Studentnumcombobox";
            Studentnumcombobox.Size = new Size(281, 33);
            Studentnumcombobox.TabIndex = 0;
            Studentnumcombobox.SelectedIndexChanged += Studentnumcombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 45);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 1;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(489, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فردی دانشجو";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 229);
            label9.Name = "label9";
            label9.Size = new Size(360, 25);
            label9.TabIndex = 8;
            label9.Text = "دروس انتخاب شده توسط دانشجو در ترم کنونی";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(388, 140);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(81, 25);
            label8.TabIndex = 7;
            label8.Text = "جنسیت : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 101);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(76, 25);
            label7.TabIndex = 6;
            label7.Text = "نام پدر : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 53);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(163, 25);
            label6.TabIndex = 5;
            label6.Text = "نام و نام خانوادگی : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 181);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(0, 25);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 140);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 101);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 53);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            label2.TextChanged += label2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(6, 266);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 154);
            listBox1.TabIndex = 0;
            // 
            // LessonChoosingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Studentnumcombobox);
            Name = "LessonChoosingForm";
            Text = "پنل انتخاب واحد";
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
        private ListBox listBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
    }
}