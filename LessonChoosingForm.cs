using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp_Connected_To_LocalDB
{
    public partial class LessonChoosingForm : Form
    {
        public Userpannel userpannel;
        string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        public LessonChoosingForm()
        {
            InitializeComponent();
        }

        private void LessonChoosingForm_Load(object sender, EventArgs e)
        {
            string lfusername = userpannel.textBox1.Text;
            groupBox1.Enabled = false;
            label8.Hide();
            comboBox1.Hide();
            LessonLogButton.Hide();
            Submitbutton.Hide();
            listBox1.ScrollAlwaysVisible = true;

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

        private void Studentnumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            listBox1.HorizontalScrollbar = true;
            comboBox1.Show();
            label8.Show();
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");

            conn.Open();
            conn2.Open();
            conn3.Open();
            string query = "SELECT Fname , Lname , Fathername , Gender , Studentwalletbalance , Studentnumber , CurrentTerm FROM Students";
            string query2 = "SELECT Submitternumber ,Submittedlessonname , Submittedlessoncode FROM LessonChoosingLog";
            string query3 = "SELECT Lessonname , Lessoncode , Teachersname , classtime , classday , examdate From Lessons";
            SqlCommand cmd3 = new SqlCommand(query3, conn3);
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            SqlDataReader reader3 = cmd3.ExecuteReader();

            string check = Studentnumcombobox.Text;
            while (reader.Read())
            {
                string studentnumber = reader["Studentnumber"].ToString();
                if (studentnumber == check)
                {
                    string name = reader["Fname"].ToString();
                    string Lname = reader["Lname"].ToString();
                    string currentterm = reader["CurrentTerm"].ToString();
                    string Fathername = reader["Fathername"].ToString();
                    string Gender = reader["Gender"].ToString();
                    label2.Text = name + " " + Lname;
                    label3.Text = Fathername;
                    label4.Text = Gender;
                    if (int.Parse(currentterm) == 9500)
                    {
                        label5.Text = "ترم کنونی دانشجو : ترم یک سال 1401";

                    }
                    else
                        label5.Text = "ترم کنونی دانشجو : ترم دو سال 1401";

                }
                else
                    continue;
            }



            conn.Close();
            conn2.Close();
            conn3.Close();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            LessonLogButton.Show();
            Submitbutton.Enabled = false;
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

            SqlConnection conn5 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            conn5.Open();


            while (studentreader.Read())
            {
                string studentnumber = studentreader["Studentnumber"].ToString();
                if (studentnumber == check)
                {
                    string currentterm = studentreader["CurrentTerm"].ToString();
                    int currenttermint = int.Parse(currentterm);

                    string selectorquery = "SELECT * FROM Lessons WHERE RequiredSemester ='" + currenttermint + "'";
                    SqlCommand scselector = new SqlCommand(selectorquery, conn5);
                    SqlDataReader readercombobox = scselector.ExecuteReader();
                    while (readercombobox.Read())
                    {
                        string lessonname = readercombobox["Lessonname"].ToString();
                        string lessoncode = readercombobox["Lessoncode"].ToString();
                        string Teachersname = readercombobox["Teachersname"].ToString();
                        string Startdate = readercombobox["Startdate"].ToString();
                        string Enddate = readercombobox["Enddate"].ToString();
                        string classtime = readercombobox["classtime"].ToString();
                        string classday = readercombobox["classday"].ToString();
                        string lessonvalue = readercombobox["lessonvalue"].ToString();
                        string examdate = readercombobox["examdate"].ToString();
                        string RequiredSemester = readercombobox["RequiredSemester"].ToString();

                        comboBox1.Items.Add("نام درس : " + lessonname + " | " + " نام استاد : " + Teachersname + " | " + "تعداد واحد : " + lessonvalue + " واحدی " + " | " + " تاریخ شروغ : " + Startdate + " | " + " تاریخ پایان : " + Enddate + " | " + " تاریخ امتحان : " + examdate + " | " + " کد درس : " + " | " + lessoncode);
                    }

                }
                else
                    continue;

            }




            conn.Close();
            conn2.Close();
            conn3.Close();
            conn4.Close();
            conn5.Close();
        }
        private void LessonChoosingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            userpannel.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text;
            label9.Text = comboBox1.Text.Substring(comboBox1.Text.Length - 4);
            label9.Hide();
            Submitbutton.Show();
            Submitbutton.Enabled = true;
        }

        private void GotoUPButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpannel.Show();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            bool y = false;
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");
            SqlConnection conn3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + directory + "\\MainDataBase.mdf;Integrated Security=True;");

            conn.Open();
            conn2.Open();
            conn3.Open();
            string code = label9.Text;
            string queryselector = "SELECT * FROM Lessons WHERE Lessoncode='" + code + "'";
            SqlCommand cmd = new SqlCommand(queryselector, conn);
            SqlDataReader selectorreader = cmd.ExecuteReader();
            selectorreader.Read();

            string lessonname = selectorreader["Lessonname"].ToString();
            string Teachersname = selectorreader["Teachersname"].ToString();
            string Startdate = selectorreader["Startdate"].ToString();
            string Enddate = selectorreader["Enddate"].ToString();
            string classtime = selectorreader["classtime"].ToString();
            string classday = selectorreader["classday"].ToString();
            string lessonvalue = selectorreader["lessonvalue"].ToString();
            string examdate = selectorreader["examdate"].ToString();
            string RequiredSemester = selectorreader["RequiredSemester"].ToString();

            string submitter = Studentnumcombobox.Text;
            string queryinsertor = "INSERT INTO LessonChoosingLog (Submitternumber,Submittedlessonname,Submittedlessoncode) VALUES ('" + submitter + "','" + lessonname + "','" + code + "')";
            SqlCommand cmdinsertor = new SqlCommand(queryinsertor, conn2);

            string querychecker = "SELECT Submitternumber , Submittedlessoncode FROM LessonChoosingLog";
            SqlCommand cmdchecker = new SqlCommand(querychecker, conn3);
            SqlDataReader readerchecker = cmdchecker.ExecuteReader();
            while (readerchecker.Read()) //this loop is used to check if the lesson is already submitted by this student or not
            {
                string submitternumber = readerchecker["Submitternumber"].ToString();
                string submittedlessoncode = readerchecker["Submittedlessoncode"].ToString();
                if (submitternumber == submitter && submittedlessoncode == code)
                {
                    y = true;
                }
                else
                {
                    continue;
                }

            }
            if (y == true)
            {
                MessageBox.Show("این درس قبلا توسط این دانشجو انتخاب شده است");
            }
            else if (y == false)
            {
                cmdinsertor.ExecuteNonQuery();
                MessageBox.Show("درس با موفقیت انتخاب شد");
            }
            refresh();

            conn.Close();
            conn2.Close();
            conn3.Close();

        }
        public void refresh() //used to refresh the log list
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

        private void LessonLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userpannel.Lessonlogform.Show();
        }
    }

}






