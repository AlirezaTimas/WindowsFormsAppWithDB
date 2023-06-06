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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Studentnumcombobox
            // 
            Studentnumcombobox.FormattingEnabled = true;
            Studentnumcombobox.Location = new Point(521, 98);
            Studentnumcombobox.Name = "Studentnumcombobox";
            Studentnumcombobox.Size = new Size(267, 33);
            Studentnumcombobox.TabIndex = 0;
            Studentnumcombobox.SelectedIndexChanged += Studentnumcombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 54);
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
            groupBox1.Size = new Size(489, 429);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فردی دانشجو";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 236);
            label6.Name = "label6";
            label6.Size = new Size(402, 25);
            label6.TabIndex = 9;
            label6.Text = "دروس انتخاب شده توسط این دانشجو در ترم کنونی : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 194);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 132);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 89);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 45);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 5;
            label2.TextChanged += label2_TextChanged;
            // 
            // genderllabel
            // 
            genderllabel.AutoSize = true;
            genderllabel.Location = new Point(402, 132);
            genderllabel.Name = "genderllabel";
            genderllabel.Size = new Size(81, 25);
            genderllabel.TabIndex = 3;
            genderllabel.Text = "جنسیت : ";
            // 
            // fathernlabel
            // 
            fathernlabel.AutoSize = true;
            fathernlabel.Location = new Point(412, 89);
            fathernlabel.Name = "fathernlabel";
            fathernlabel.Size = new Size(71, 25);
            fathernlabel.TabIndex = 2;
            fathernlabel.Text = "نام پدر :";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(320, 45);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(163, 25);
            namelabel.TabIndex = 1;
            namelabel.Text = "نام و نام خانوادگی : ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(6, 273);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 154);
            listBox1.TabIndex = 0;
            // 
            // LessonChoosingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Studentnumcombobox);
            Name = "LessonChoosingForm";
            Text = "LessonChoosingForm";
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
    }
}