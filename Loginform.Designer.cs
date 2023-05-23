namespace WindowsFormsApp_Connected_To_LocalDB
{
    partial class Loginform
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
            LoginButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(72, 228);
            LoginButton.Margin = new Padding(2, 3, 2, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(275, 59);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "ورود";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(72, 79);
            usernameTextBox.Margin = new Padding(2, 3, 2, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(275, 34);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "نام کاربری خود را وارد کنید";
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            usernameTextBox.Enter += usernameTextBox_Enter;
            usernameTextBox.Leave += usernameTextBox_Leave;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(72, 153);
            passwordTextBox.Margin = new Padding(2, 3, 2, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(275, 34);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "رمز عبور خود را وارد کنید";
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(422, 363);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(LoginButton);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Loginform";
            Text = "صفحه ورود";
            FormClosing += Loginform_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        public TextBox usernameTextBox;
        private TextBox passwordTextBox;
    }
}