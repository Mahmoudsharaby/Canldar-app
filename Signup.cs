using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
      
        User.User_Preference account = new User.User_Preference();
        notification.notifi mail= new notification.notifi();
        public Signup()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox4.Text;
            string email = textBox2.Text;
            string birth = dateTimePicker1.Text; 
            bool v = account.Create_User(name, email, birth, pass);
            if (v==true)
            {
                MessageBox.Show("User exist!\n Change User name!");
            }
            else
            {
                MessageBox.Show("The account is created!");
                mail.sent_email_signup(email, name);
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
