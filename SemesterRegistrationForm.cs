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

namespace WindowsFormsApp_Connected_To_LocalDB
{
    public partial class SemesterRegistrationForm : Form
    {
        public Loginform loginform;
        public Userpannel userpannel;
        public BalanceIncreaseFrom balanceform;
        public SemesterRegistrationLogForm semlogform;

        public SemesterRegistrationForm()
        {
            InitializeComponent();


        }

        private void TuitionPaymentPannel_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            TermComboB.Enabled = false;
            this.StudentNumCB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TermComboB.DropDownStyle = ComboBoxStyle.DropDownList;


            string lfusername = userpannel.textBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            conn.Open();
            string queryf = "SELECT Fname , Lname , Studentnumber , usernameinsystem FROM Students ";
            string querysec = "SELECT Termname , termcode FROM Terms";
            SqlCommand cmd = new SqlCommand(queryf, conn);
            SqlCommand cmd2 = new SqlCommand(querysec, conn);
            SqlDataReader dr = cmd.ExecuteReader();




            while (dr.Read())
            {
                if (lfusername == "admin")
                {
                    string studentnum = dr["Studentnumber"].ToString();
                    StudentNumCB.Items.Add(studentnum);

                }
                else
                {
                    string username = dr["usernameinsystem"].ToString();
                    if (username == lfusername)
                    {
                        string studentnum = dr["Studentnumber"].ToString();
                        StudentNumCB.Items.Add(studentnum);

                    }
                    else
                        continue;
                }
            }
            conn.Close();
            conn.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string termname = dr2["Termname"].ToString();
                TermComboB.Items.Add(termname);

            }
            conn.Close();


        }

        private void GoToUCPButton_Click(object sender, EventArgs e)
        {
            userpannel.Show();
            this.Hide();
        }

        private void StudentNumCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            TermComboB.Enabled = true;
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            conn.Open();
            string query = "SELECT Fname , Lname , Studentnumber , Birthplace , Fathername , Gender FROM Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string studentnumber = dr["Studentnumber"].ToString();
                string check = StudentNumCB.Text;
                if (studentnumber == check)
                {
                    string fname = dr["Fname"].ToString();
                    string Lname = dr["Lname"].ToString();
                    string birthplace = dr["Birthplace"].ToString();
                    string fathername = dr["Fathername"].ToString();
                    string gender = dr["Gender"].ToString();


                    infolabel.Text = " نام : " + fname + " " + Lname + "\n جنسیت : " + gender + "\n نام پدر : " + fathername + "\n محل تولد : " + birthplace + "";
                }
                else
                    continue;
            }
            conn.Close();
        }

        public void StudentNumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            TermComboB.Enabled = true;
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            conn.Open();
            string query = "SELECT Fname , Lname , Studentnumber , Birthplace , Fathername , Gender , studentwalletbalance FROM Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string studentnumber = dr["Studentnumber"].ToString();
                string check = StudentNumCB.Text;
                if (studentnumber == check)
                {
                    string fname = dr["Fname"].ToString();
                    string Lname = dr["Lname"].ToString();
                    string birthplace = dr["Birthplace"].ToString();
                    string fathername = dr["Fathername"].ToString();
                    string gender = dr["Gender"].ToString();
                    string studentwalletbalance = dr["studentwalletbalance"].ToString();


                    infolabel.Text = " نام : " + fname + " " + Lname + "\n جنسیت : " + gender + "\n نام پدر : " + fathername + "\n محل تولد : " + birthplace + "";
                    BalanceLabel.Text = "موجودی حساب دانشجویی : " + studentwalletbalance + " ";
                }
                else
                    continue;
            }
            conn.Close();
        }

        private void TermComboB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            connection.Open();
            string query = "SELECT studentwalletbalance , Studentnumber FROM Students";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            string query2 = "SELECT termprice , Termname FROM Terms";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            while (dr.Read())
            {
                string studentnumber = dr["Studentnumber"].ToString();
                string check = StudentNumCB.Text;
                if (studentnumber == check)
                {
                    string studentwalletbalance = dr["studentwalletbalance"].ToString();

                    BalanceLabel.Text = "موجودی حساب دانشجویی : " + studentwalletbalance + " ";
                }
                else
                    continue;
            }
            connection.Close();
            connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string combotermname = TermComboB.Text;


                string Termname = dr2["Termname"].ToString();
                if (Termname == combotermname)
                {
                    string termprice = dr2["termprice"].ToString();
                    pricelabel.Text = "      شهریه ترم انتخاب شده : " + termprice + " ";
                }

            }
            connection.Close();

        }
        int termregcode = 1000;
        private void PayButton_Click(object sender, EventArgs e)
        {
            termregcode++;
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            SqlConnection connection2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            SqlConnection connection3= new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            SqlConnection connection4 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");

            connection.Open();
            connection2.Open();
            connection3.Open();
            connection4.Open();



            string query = "SELECT studentwalletbalance , Studentnumber FROM Students";
            string query2 = "SELECT Termname , termprice , termcode FROM Terms";


            SqlCommand cmd = new SqlCommand(query, connection);
            SqlCommand cmd2 = new SqlCommand(query2, connection2);
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();



            while (dr.Read())
            {
                string studentnumber = dr["Studentnumber"].ToString();

                if (studentnumber == StudentNumCB.Text)
                {
                    string studentwalletbalance = dr["studentwalletbalance"].ToString();
                    while (dr2.Read())
                    {
                        string termname = dr2["Termname"].ToString();

                        if (termname == TermComboB.Text)
                        {
                            string termcode = dr2["termcode"].ToString();
                            string termprice = dr2["termprice"].ToString();
                            int studentwalletbalancee = int.Parse(studentwalletbalance);
                            int termpricee = int.Parse(termprice);

                            if (studentwalletbalancee >= termpricee)
                            {
                                string date = DateTime.Now.ToString();
                                string query3 = "INSERT INTO SemesterRegistrations (SemesterName,SemesterCode,StudentNumber,RegistrationDate,Termregcode) VALUES ('" + termname + "','" + termcode + "','" + studentnumber + "','" + date + "','" + termregcode+"')";
                                SqlCommand command3 = new SqlCommand(query3, connection3);
                                command3.ExecuteNonQuery();
                                MessageBox.Show("ثبت نام شما با موفقیت انجام شد");
                                int newbalance = studentwalletbalancee - termpricee;

                                string query4 = "UPDATE Students SET studentwalletbalance='" + newbalance + "' WHERE Studentnumber='" + studentnumber + "'";
                                SqlCommand command4 = new SqlCommand(query4, connection4);
                                command4.ExecuteNonQuery();
                                button1.PerformClick();

                            }
                            else
                                MessageBox.Show("موجودی حساب شما کافی نمیباشد ، لطفا نسبت به افزایش موجودی اقدام نمایید");
                        }
                        else
                            continue;
                    }


                }
                else
                    continue;


            }

            connection.Close();
            connection2.Close();
            connection3.Close();
            connection4.Close();


        }

        private void GoToPayPButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceform.Show();
        }

        private void GoToPayLButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            semlogform.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            connection.Open();
            string query = "SELECT studentwalletbalance , Studentnumber FROM Students";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            string query2 = "SELECT termprice , Termname FROM Terms";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            while (dr.Read())
            {
                string studentnumber = dr["Studentnumber"].ToString();
                string check = StudentNumCB.Text;
                if (studentnumber == check)
                {
                    string studentwalletbalance = dr["studentwalletbalance"].ToString();

                    BalanceLabel.Text = "موجودی حساب دانشجویی : " + studentwalletbalance + " ";
                }
                else
                    continue;

            }
            connection.Close();
        }

        private void SemesterRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            userpannel.Show();
        }
    }
}
