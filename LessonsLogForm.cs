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
    public partial class LessonsLogForm : Form
    {
        public Userpannel userpannel;
        string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        public LessonsLogForm()
        {
            InitializeComponent();
        }

        private void LessonsLogForm_Load(object sender, EventArgs e)
        {
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

        private void LessonsLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            userpannel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpannel.Show();
        }

        private void Studentnumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn4 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            conn.Open();
            conn2.Open();
            conn3.Open();

            string query = "SELECT Id, Fname , Lname , Fathername , Gender , Studentwalletbalance , Studentnumber , CurrentTerm FROM Students";
            string query2 = "SELECT Id, Submitternumber ,Submittedlessonname , Submittedlessoncode FROM LessonChoosingLog";
            string query3 = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            SqlCommand cmd3 = new SqlCommand(query3, conn3);

            SqlDataReader studentreader = cmd.ExecuteReader();
            SqlDataReader logreader = cmd2.ExecuteReader();

            string check = Studentnumcombobox.Text;



            while (logreader.Read())
            {
                string submitternumber = logreader["Submitternumber"].ToString();
                int intcheck = int.Parse(check);
                int subnum = int.Parse(submitternumber);
                if (intcheck == subnum)
                {


                    string submittedlessoncode = logreader["Submittedlessoncode"].ToString();
                    string lquery = "SELECT * FROM Lessons WHERE Lessoncode='" + submittedlessoncode + "' ";
                    SqlCommand cmd4 = new SqlCommand(lquery, conn4);
                    conn4.Open();
                    SqlDataReader reader = cmd4.ExecuteReader();

                    reader.Read();
                    string teachersname = reader["teachersname"].ToString();
                    string classtime = reader["classtime"].ToString();
                    string classday = reader["classday"].ToString();
                    string examdate = reader["examdate"].ToString();
                    string lessonname = reader["lessonname"].ToString();


                    listBox1.Items.Add(" نام درس : " + lessonname + " | " + " نام استاد : " + teachersname + " | " + " روز و ساعت کلاس : " + classday + " " + classtime + " | " + " تاریخ امتحان : " + examdate + " ");
                    listBox1.Items.Add("------------------------------------------------------------------------------------------");
                    conn4.Close();
                }
                else
                    continue;
            }
            conn.Close();
            conn2.Close();
            conn3.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn4 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            conn.Open();
            conn2.Open();
            conn3.Open();

            string query = "SELECT Id, Fname , Lname , Fathername , Gender , Studentwalletbalance , Studentnumber , CurrentTerm FROM Students";
            string query2 = "SELECT Id, Submitternumber ,Submittedlessonname , Submittedlessoncode FROM LessonChoosingLog";
            string query3 = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            SqlCommand cmd3 = new SqlCommand(query3, conn3);

            SqlDataReader studentreader = cmd.ExecuteReader();
            SqlDataReader logreader = cmd2.ExecuteReader();

            string check = Studentnumcombobox.Text;



            while (logreader.Read())
            {
                string submitternumber = logreader["Submitternumber"].ToString();
                int intcheck = int.Parse(check);
                int subnum = int.Parse(submitternumber);
                if (intcheck == subnum)
                {


                    string submittedlessoncode = logreader["Submittedlessoncode"].ToString();
                    string lquery = "SELECT * FROM Lessons WHERE Lessoncode='" + submittedlessoncode + "' ";
                    SqlCommand cmd4 = new SqlCommand(lquery, conn4);
                    conn4.Open();
                    SqlDataReader reader = cmd4.ExecuteReader();

                    reader.Read();
                    string teachersname = reader["teachersname"].ToString();
                    string classtime = reader["classtime"].ToString();
                    string classday = reader["classday"].ToString();
                    string examdate = reader["examdate"].ToString();
                    string lessonname = reader["lessonname"].ToString();


                    listBox1.Items.Add(" نام درس : " + lessonname + " | " + " نام استاد : " + teachersname + " | " + " روز و ساعت کلاس : " + classday + " " + classtime + " | " + " تاریخ امتحان : " + examdate + " ");
                    listBox1.Items.Add("------------------------------------------------------------------------------------------");
                    conn4.Close();
                }
                else
                    continue;
            }
            conn.Close();
            conn2.Close();
            conn3.Close();

        }
    }
}
