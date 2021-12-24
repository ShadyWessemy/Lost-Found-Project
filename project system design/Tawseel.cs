using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class Tawseel : Form
    {
        public Tawseel()
        {
            InitializeComponent();
        }

        private void deliverbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // visa details button
        {
            if(radioButton1.Checked==true||textBox1.Text!=null)
            {
                if(textBox2.Text!=null&&comboBox1.Text=="Visa")
                {
                    this.Hide();
                    Visa v = new Visa();
                    v.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // place order button
        {
            if(radioButton1.Checked==true||textBox1.Text!=null)
            {
                if (textBox2.Text!=null&&comboBox1.Text=="Cash")
                {
                    MessageBox.Show("Your order is placed");
                }
            }
            if (radioButton1.Checked == true || textBox1.Text != null)
            {
                if (textBox2.Text != null && comboBox1.Text == "Visa")
                {
                    MessageBox.Show("Please press visa details button");
                }
            }
            


        }

        private void button3_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            Preview p = new Preview();
            p.ShowDialog();
            this.Close();
        }
    }
}
