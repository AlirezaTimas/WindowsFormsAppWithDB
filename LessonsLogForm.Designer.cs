namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class LessonsLogForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Studentnumcombobox
            // 
            Studentnumcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Studentnumcombobox.FormattingEnabled = true;
            Studentnumcombobox.Location = new Point(363, 48);
            Studentnumcombobox.Name = "Studentnumcombobox";
            Studentnumcombobox.Size = new Size(254, 33);
            Studentnumcombobox.TabIndex = 0;
            Studentnumcombobox.SelectedIndexChanged += Studentnumcombobox_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 96);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(939, 454);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 2;
            label1.Text = "شماره دانشجویی خود را انتخاب کنید";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 31);
            button1.Name = "button1";
            button1.Size = new Size(255, 50);
            button1.TabIndex = 3;
            button1.Text = " بازگشت به پنل کاربری";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(696, 31);
            button2.Name = "button2";
            button2.Size = new Size(255, 50);
            button2.TabIndex = 4;
            button2.Text = "به روزرسانی لیست";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LessonsLogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 561);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(Studentnumcombobox);
            Name = "LessonsLogForm";
            Text = "LessonsLogForm";
            FormClosing += LessonsLogForm_FormClosing;
            Load += LessonsLogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Studentnumcombobox;
        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}