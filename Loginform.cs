using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WindowsFormsApp_Connected_To_LocalDB
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            userp.loginform = this;
            exitform.loginform = this;
            tuitionp.loginform = this;

        }
        Userpannel userp = new Userpannel();
        ExitForm exitform = new ExitForm();
        SemesterRegistrationForm tuitionp = new SemesterRegistrationForm();
       

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "نام کاربری خود را وارد کنید")
            {
                usernameTextBox.Text = "";
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "رمز عبور خود را وارد کنید")
            {
                passwordTextBox.Text = "";
            }
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {

                usernameTextBox.Text = "نام کاربری خود را وارد کنید";
            }

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "رمز عبور خود را وارد کنید";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = usernameTextBox.Text;
            string pass = passwordTextBox.Text;
            SqlConnection sc = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            sc.Open();
            string query = "SELECT Username , Password , Id FROM users";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            string id = "0";
            if (usernameTextBox.Text == "نام کاربری خود را وارد کنید" || usernameTextBox.Text == "" || passwordTextBox.Text == "" || passwordTextBox.Text == "رمزعبور خود را وارد کنید")
            {
                MessageBox.Show("لطفا فیلد ها رو خالی نگذارید", "فیلد ها رو پر کنید");
            }
            else
            {

                while (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string password = reader["Password"].ToString();
                    if (username == usernameTextBox.Text && password == passwordTextBox.Text)
                    {
                        id = reader["Id"].ToString();
                        break;

                    }

                }
                int check = int.Parse(id);
                if (check > 0)
                {
                    userp.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");

            }
            sc.Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "رمز عبور خود را وارد کنید")
            {
                passwordTextBox.UseSystemPasswordChar = false;

            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            exitform.Show();
        }
    }
}
