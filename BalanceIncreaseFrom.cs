using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Connected_To_LocalDB
{
    public partial class BalanceIncreaseFrom : Form
    {
        public Userpannel userpannel;
        public SemesterRegistrationForm tuitionpannel;
        public PaymentLogForm paymentlogform;
        string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        public BalanceIncreaseFrom()
        {
            InitializeComponent();

        }

        private void BalanceIncreaseFrom_Load(object sender, EventArgs e)
        {
            this.Studentnumcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            string lfusername = userpannel.textBox1.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            conn.Open();
            string queryf = "SELECT Fname , Lname , Studentnumber , usernameinsystem FROM Students ";
            SqlCommand cmd = new SqlCommand(queryf, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (lfusername == "admin")
                {
                    string studentnum = dr["Studentnumber"].ToString();
                    Studentnumcombobox.Items.Add(studentnum);

                }
                else
                {
                    string username = dr["usernameinsystem"].ToString();
                    if (username == lfusername)
                    {
                        string studentnum = dr["Studentnumber"].ToString();
                        Studentnumcombobox.Items.Add(studentnum);

                    }
                    else
                        continue;
                }
            }
            conn.Close();
        }

        private void GoToUserPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpannel.Show();
        }
        public int PaymentCode = 1000;
        private void PayButton_Click(object sender, EventArgs e)
        {
            PaymentCode++;

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");

            conn.Open();
            conn2.Open();
            conn3.Open();
            string query = "SELECT Studentnumber , studentwalletbalance FROM Students";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string studentnumber = dr["Studentnumber"].ToString();
                if (studentnumber == Studentnumcombobox.Text)
                {
                    string studentwalletbalance = dr["studentwalletbalance"].ToString();
                    int walletbalance = int.Parse(studentwalletbalance);
                    if (AmountTextBox.Text == "")
                    {
                        MessageBox.Show("لطفا فیلد مبلغ را خالی نگذارید");
                        break;
                    }
                    else
                    {
                        int enteredbalance = int.Parse(AmountTextBox.Text);
                        int newbalance = walletbalance + enteredbalance;
                        string query2 = "UPDATE Students SET studentwalletbalance='" + newbalance + "' WHERE Studentnumber='" + studentnumber + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, conn2);
                        cmd2.ExecuteNonQuery();
                        string date = DateTime.Now.ToString();
                        string receiver = "Apadana University";
                        string query3 = "INSERT INTO Payments (PaymentCode,PaymentDate,Submitter,Receiver,Amount) VALUES ('" + PaymentCode + "','" + date + "','" + studentnumber + "','" + receiver + "','" + enteredbalance + "')";
                        SqlCommand cmd3 = new SqlCommand(query3, conn3);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show(" پرداخت با موفقیت انجام شد، موجودی جدید حساب شما : " + newbalance + " ");
                        AmountTextBox.Text = "";
                        label10.Text = newbalance.ToString();

                    }

                }
                else
                    continue;
            }
            conn3.Close();
            conn2.Close();
            conn.Close();
        }

        private void GoToPayFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            tuitionpannel.Show();
        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Studentnumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            conn.Open();
            string query = "SELECT Fname , Lname , Fathername , Gender , Studentwalletbalance , Studentnumber FROM Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string check = Studentnumcombobox.Text;
            while (reader.Read())
            {

                string studentnumber = reader["Studentnumber"].ToString();
                if (studentnumber == check)
                {
                    string name = reader["Fname"].ToString();
                    string Lname = reader["Lname"].ToString();
                    string studentwalletbalance = reader["studentwalletbalance"].ToString();
                    string Fathername = reader["Fathername"].ToString();
                    string Gender = reader["Gender"].ToString();
                    label7.Text = name + " " + Lname;
                    label8.Text = Fathername;
                    label9.Text = Gender;
                    label10.Text = studentwalletbalance;
                }
                else
                    continue;
            }
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PayLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentlogform.Show();
        }

        private void BalanceIncreaseFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            userpannel.Show();
        }
    }
}
