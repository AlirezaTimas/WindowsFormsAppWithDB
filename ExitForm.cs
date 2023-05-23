using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Connected_To_LocalDB
{
    public partial class ExitForm : Form
    {
        public Loginform loginform;
        public Userpannel userpannel;
        public ExitForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void ExitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
