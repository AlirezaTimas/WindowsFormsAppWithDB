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
    public partial class SemesterRegistrationLogForm : Form
    {
        public Userpannel userpannel;
        public SemesterRegistrationForm semesterregform;
        public SemesterRegistrationLogForm()
        {
            InitializeComponent();
        }

        private void SemesterRegisterationLogForm_Load(object sender, EventArgs e)
        {
            loglistbox.Enabled = false;
            string lfusername = userpannel.textBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            conn.Open();
            string query = "SELECT Fname , Lname , Studentnumber , usernameinsystem FROM Students ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (lfusername == "admin")
                {
                    string studentnum = reader["Studentnumber"].ToString();
                    StudentnumCB.Items.Add(studentnum);

                }
                else
                {
                    string username = reader["usernameinsystem"].ToString();
                    if (username == lfusername)
                    {
                        string studentnum = reader["Studentnumber"].ToString();
                        StudentnumCB.Items.Add(studentnum);

                    }
                    else
                        continue;
                }
            }
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loglistbox.Enabled = true;
            string check = StudentnumCB.Text;
            SqlConnection sc = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");
            SqlConnection sc2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Markazi.co\\source\\repos\\AlirezaTimas\\WindowsFormsAppWithDB\\MainDataBase.mdf; Integrated Security = True");

            sc.Open();
            sc2.Open();
            string query = "SELECT SemesterName,SemesterCode,StudentNumber,RegistrationDate,Id,Termregcode FROM SemesterRegistrations";
            string query2 = "SELECT Fname,Lname,Studentnumber FROM Students";

            SqlCommand cmd = new SqlCommand(query, sc);
            SqlCommand cmd2 = new SqlCommand(query2, sc2);
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string studentnumber = reader2["Studentnumber"].ToString();
                if (studentnumber == check)
                {
                    while (reader.Read())
                    {
                        string studentnumberr = reader["Studentnumber"].ToString();
                        if (studentnumberr == studentnumber)
                        {
                            string semestername = reader["SemesterName"].ToString();
                            string semestercode = reader["SemesterCode"].ToString();
                            string id = reader["Id"].ToString();
                            string termregcode = reader["Termregcode"].ToString() ; 
                            string regdate = reader["RegistrationDate"].ToString();
                            string fname = reader2["Fname"].ToString();
                            string Lname = reader2["Lname"].ToString();
                            loglistbox.Items.Clear();
                            loglistbox.Items.Add("ثبت نام دانشجو با نام : " + fname + " " + Lname + " در ترم : " + semestername + " با کد ترم : " + semestercode + " در تاریخ : " + regdate + " با موفقیت انجام شد. ");
                            while (reader.Read())
                            { 
                                int i = int.Parse(termregcode);
                                string idd = reader["Id"].ToString();
                                string num = reader["StudentNumber"].ToString();
                                int j = int.Parse(termregcode);
                                if (i==j++ && num == studentnumber)
                                {
                                    string semesternamee = reader["SemesterName"].ToString();
                                    string semestercodee = reader["SemesterCode"].ToString();
                                   string iddd = reader["Id"].ToString();
                                    string regdatee = reader["RegistrationDate"].ToString();
                                    string fnamee = reader2["Fname"].ToString();
                                    string Lnamee = reader2["Lname"].ToString();
                                   
                                    loglistbox.Items.Add("ثبت نام دانشجو با نام : " + fnamee + " " + Lnamee + " در ترم : " + semesternamee + " با کد ترم : " + semestercodee + " در تاریخ : " + regdatee + " با موفقیت انجام شد. ");
                                  
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
            sc.Close();
            sc2.Close();
        }

        private void GoToPayFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            semesterregform.Show();

        }

        private void GoToUserPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpannel.Show();
        }

        private void SemesterRegistrationLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            userpannel.Show();
        }
    }
}
