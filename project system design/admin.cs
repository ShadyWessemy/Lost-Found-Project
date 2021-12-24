using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class admin : Form
    {
        // 1 refer to normal
        // 2 refer to geha khasa
        public static string kind1;
        public static string gov1;
        public static string name1;
        public static string no1;
        public static string kind2;
        public static string gov2;
        public static string name2;
        public static string no2;
        public static string special;
        

        public admin()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e) //enter data  
        {
            if(kind1combo.SelectedItem == null||gov1combo.SelectedItem==null||comboBox1.SelectedItem == null||name1text.Text==null||no1text.Text==null)
            {
                MessageBox.Show("يرجى إدخال البيانات كاملة");
            }
            else
            {

                if (comboBox1.Text == "لا يوجد")
                {
                    kind1 = kind1combo.Text;
                    gov1 = gov1combo.Text;
                    name1 = name1text.Text;
                    no1 = no1text.Text;
                    MessageBox.Show("تم إدخال البيانات");
                }
                else
                {
                    kind2 = kind1combo.Text;
                    gov2 = gov1combo.Text;
                    name2 = name1text.Text;
                    no2 = no1text.Text;
                    special = comboBox1.Text;
                    MessageBox.Show("تم إدخال البيانات في الجهة الخاصة");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
           
        }

        private void button2_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
    }
}
