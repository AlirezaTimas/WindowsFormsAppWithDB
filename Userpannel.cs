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
    public partial class Userpannel : Form
    {
        public Loginform loginform;
        public ExitForm exitform = new ExitForm();
        public SemesterRegistrationForm tuitionp = new SemesterRegistrationForm();
        public BalanceIncreaseFrom balancep = new BalanceIncreaseFrom();
        public PaymentLogForm paymentlogform = new PaymentLogForm();
        public SemesterRegistrationLogForm serlform = new SemesterRegistrationLogForm();
        public LessonChoosingForm lessonform = new LessonChoosingForm();
        public LessonsLogForm Lessonlogform = new LessonsLogForm();

        public Userpannel()
        {
            InitializeComponent();
            exitform.userpannel = this;
            tuitionp.userpannel = this;
            balancep.userpannel = this;
            paymentlogform.userpannel = this;
            serlform.userpannel = this;
            lessonform.userpannel = this;
            balancep.tuitionpannel = tuitionp;
            tuitionp.balanceform = balancep;
            balancep.paymentlogform = paymentlogform;
            paymentlogform.balanceform = balancep;
            serlform.semesterregform = tuitionp;
            tuitionp.semlogform = serlform;
            Lessonlogform.userpannel = this;
        }

        private void Userpannel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            exitform.Show();
        }

        private void Userpannel_Load(object sender, EventArgs e)
        {
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            exitform.Show();
        }

        private void TuitionPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            tuitionp.Show();

        }

        private void Userpannel_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = loginform.usernameTextBox.Text;
            textBox1.Enabled = false;

        }

        private void WalletButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            balancep.Show();
        }

        private void WalletPaymentsLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentlogform.Show();
        }

        private void TuitionLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            serlform.Show();
        }

        private void ChoosingLessonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lessonform.Show();
        }

        private void LessonsLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lessonlogform.Show();
        }
    }
}