using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LibrarySystemProject
{
    public partial class WFLogin : Form
    {
        static string Username;
        Thread th;

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

            if (Username == "Joshua" && Password == "Joshua")
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else
            {
                MessageBox.Show("The UserName And Password You Entered Is Incorect", "Login Page Wrong Password");
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new Welcome());
        }
    }
}
