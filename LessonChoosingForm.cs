﻿using System;
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

namespace WindowsFormsApp_Connected_To_LocalDB
{
    public partial class LessonChoosingForm : Form
    {
        public Userpannel userpannel;
        public LessonChoosingForm()
        {
            InitializeComponent();
        }

        private void LessonChoosingForm_Load(object sender, EventArgs e)
        {
            string lfusername = userpannel.textBox1.Text;
            groupBox1.Enabled = false;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
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
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            SqlConnection conn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");

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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");
            SqlConnection conn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio Projects\AppWithDatabase\MainDataBase.mdf"";Integrated Security=True");

            conn.Open();
            conn2.Open();
            conn3.Open();
            string query = "SELECT Id, Fname , Lname , Fathername , Gender , Studentwalletbalance , Studentnumber , CurrentTerm FROM Students";
            string query2 = "SELECT Id, Submitternumber ,Submittedlessonname , Submittedlessoncode FROM LessonChoosingLog";
            string query3 = "SELECT Id , Lessonname , Lessoncode , Teachersname , classtime , classday , examdate From Lessons";
            SqlCommand cmd3 = new SqlCommand(query3, conn3);
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader studentreader = cmd.ExecuteReader();
            SqlDataReader logreader = cmd2.ExecuteReader();
            SqlDataReader lessonreader = cmd3.ExecuteReader();
            string check = Studentnumcombobox.Text;
            int counter = 1000;
            while (studentreader.Read())
            {
                string studentnumber = studentreader["Studentnumber"].ToString();
                if (studentnumber == check)
                {
                    while (logreader.Read())
                    {
                        string submitter = logreader["Submitternumber"].ToString();

                        if (submitter == studentnumber)
                        {
                            while (lessonreader.Read())
                            {
                                string submittedcode = logreader["Submittedlessoncode"].ToString();
                                string lessoncode = lessonreader["Lessoncode"].ToString();

                                if (submittedcode == lessoncode)
                                {
                                    string teachersname = lessonreader["Teachersname"].ToString();
                                    string classtime = lessonreader["classtime"].ToString();
                                    string classday = lessonreader["classday"].ToString();
                                    string examdate = lessonreader["examdate"].ToString();
                                    string lessonname = lessonreader["Lessonname"].ToString();
                                    string id = logreader["Id"].ToString();
                                    listBox1.Items.Add(" نام درس : " + lessonname + " | " + " نام استاد : " + teachersname + " | " + " روز و ساعت کلاس : " + classday + " " + classtime + " | " + " تاریخ امتحان : " + examdate + " ");
                                    while (logreader.Read())
                                    {
                                        string submitter2 = logreader["submitternumber"].ToString();
                                        int idd = int.Parse(id);
                                        string id2 = logreader["id"].ToString();
                                        int idd2 = int.Parse(id2);
                                        if (idd2 > idd && submitter2 == check)
                                        {
                                            while (lessonreader.Read())
                                            {
                                                string submittedcode2 = logreader["submittedlessoncode"].ToString();
                                                string lessoncode2 = lessonreader["lessoncode"].ToString();
                                                if (submittedcode2 == lessoncode2)
                                                {
                                                    string teachersname2 = lessonreader["teachersname"].ToString();
                                                    string classtime2 = lessonreader["classtime"].ToString();
                                                    string classday2 = lessonreader["classday"].ToString();
                                                    string examdate2 = lessonreader["examdate"].ToString();
                                                    string lessonname2 = lessonreader["lessonname"].ToString();

                                                    listBox1.Items.Add(" نام درس : " + lessonname2 + " | " + " نام استاد : " + teachersname2 + " | " + " روز و ساعت کلاس : " + classday2 + " " + classtime2 + " | " + " تاریخ امتحان : " + examdate2 + " ");

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }

                }
            }
        
            conn.Close();
            conn2.Close();
            conn3.Close();
        }
        private void LessonChoosingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            userpannel.Show();
        }
    }

}
















