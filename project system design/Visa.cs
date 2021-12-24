using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class Visa : Form
    {
        public Visa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //place order
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox5.Text == null)
            {
                MessageBox.Show("Please Enter data");
            }
            else
                MessageBox.Show("Your order is placed");
        }

        private void button2_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            Tawseel t = new Tawseel();
            t.ShowDialog();
            this.Close();
        }
    }
}
