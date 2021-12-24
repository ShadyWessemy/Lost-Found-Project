using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class Login : Form
    {
        static string admin_password;
        static string admin_username;

        public Login()
        {
            InitializeComponent();
        }

        private void adminbutton_Click(object sender, EventArgs e) // Enter button
        {
            admin_username = "admin";
            admin_password = "admin";
            
            
             if (admin_username==usertext.Text&&admin_password==passtext.Text)
            {
                this.Hide();
                admin a = new admin();
                a.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            First f = new First();
            f.ShowDialog();
            this.Close();
        }
    }
}
