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
    public partial class PaymentLogForm : Form
    {
        public Userpannel userpannel;
        public BalanceIncreaseFrom balanceform;

        public PaymentLogForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loglistbox.Items.Clear();
            Loglistbox.Enabled = true;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            conn2.Open();
            conn.Open();
            string check = Studentnumcombobox.Text;
            string query = "SELECT Studentnumber , Fname , Lname FROM Students ";
            string query2 = "SELECT Submitter , Receiver , Amount , PaymentCode , PaymentDate FROM Payments";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string studentnumber = reader["Studentnumber"].ToString();
                if (studentnumber == check)
                {

                    while (reader2.Read())
                    {
                        string Submitter = reader2["Submitter"].ToString();

                        if (Submitter == studentnumber)
                        {
                            string receiver = reader2["Receiver"].ToString();
                            string Amount = reader2["Amount"].ToString();
                            string Paymentcode = reader2["PaymentCode"].ToString();
                            string PaymentDate = reader2["PaymentDate"].ToString();
                            string fname = reader["Fname"].ToString();
                            string Lname = reader["Lname"].ToString();
                            Loglistbox.Items.Clear();
                            Loglistbox.Items.Add(" نام : " + fname + " " + Lname + " مبلغ : " + Amount + " دریافت کننده : " + receiver + " شماره پرداخت : " + Paymentcode + " تاریخ پرداخت : " + PaymentDate + " ");
                            while (reader2.Read())
                            {
                                int i = int.Parse(Paymentcode);
                                string paymentcode = reader2["PaymentCode"].ToString();
                                int j = int.Parse(paymentcode);

                                if (i == j++)
                                {
                                    string receivere = reader2["Receiver"].ToString();
                                    string Amounte = reader2["Amount"].ToString();
                                    string Paymentcodee = reader2["PaymentCode"].ToString();
                                    string PaymentDatee = reader2["PaymentDate"].ToString();
                                    string fnamee = reader["Fname"].ToString();
                                    string Lnamee = reader["Lname"].ToString();

                                    Loglistbox.Items.Add(" نام : " + fnamee + " " + Lnamee + " مبلغ : " + Amounte + " دریافت کننده : " + receivere + " شماره پرداخت : " + Paymentcodee + " تاریخ پرداخت : " + PaymentDatee + " ");

                                }

                            }
                        }
                        else
                            continue;
                    }
                }
                else
                    continue;
            }
            Loglistbox.HorizontalScrollbar = true;
            conn.Close();
            conn2.Close();
        }

        private void PaymentLogForm_Load(object sender, EventArgs e)
        {
            Loglistbox.Enabled = false;
            string lfusername = userpannel.textBox1.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            conn.Open();
            string query = "SELECT Fname , Lname , Studentnumber , usernameinsystem FROM Students ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (lfusername == "admin")
                {
                    string studentnum = reader["Studentnumber"].ToString();
                    Studentnumcombobox.Items.Add(studentnum);

                }
                else
                {
                    string username = reader["usernameinsystem"].ToString();
                    if (username == lfusername)
                    {
                        string studentnum = reader["Studentnumber"].ToString();
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

        private void GoToBalanceFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceform.Show();
        }

        private void PaymentLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            userpannel.Show();
        }
    }
}
