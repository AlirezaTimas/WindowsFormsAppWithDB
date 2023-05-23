namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class ExitForm
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
            NoButton = new Button();
            YesButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // NoButton
            // 
            NoButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NoButton.ForeColor = Color.Red;
            NoButton.Location = new Point(166, 90);
            NoButton.Margin = new Padding(4, 4, 4, 4);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(125, 47);
            NoButton.TabIndex = 0;
            NoButton.Text = "خیر";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // YesButton
            // 
            YesButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            YesButton.ForeColor = Color.Green;
            YesButton.Location = new Point(26, 90);
            YesButton.Margin = new Padding(4, 4, 4, 4);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(124, 47);
            YesButton.TabIndex = 1;
            YesButton.Text = "بله";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 2;
            label1.Text = "آیا میخواهید از برنامه خارج شوید؟";
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 166);
            Controls.Add(label1);
            Controls.Add(YesButton);
            Controls.Add(NoButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ExitForm";
            Text = "خروج";
            FormClosing += ExitForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NoButton;
        private Button YesButton;
        private Label label1;
    }
}