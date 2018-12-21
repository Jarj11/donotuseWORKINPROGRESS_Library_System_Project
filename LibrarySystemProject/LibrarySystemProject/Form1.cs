using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemProject
{
    public partial class WFLogin : Form
    {
        static string Username;

        public WFLogin()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Joshua", "Login Page About");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            string Password = txtPassword.Text;
            Welcome f2 = new Welcome();

            if (Username == "Joshua" && Password == "Joshua") ;
            {
                f2.ShowDialog();
            }

            else
            {
                MessageBox.Show("The UserName And Password You Entered Is Incorect", "Login Page Wrong Password");
            }
        }
    }
}
