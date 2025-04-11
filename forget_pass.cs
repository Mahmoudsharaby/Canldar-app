using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class forget_pass : Form
    {
       User.User_Preference account=new User.User_Preference();
        notification.notifi mail=new notification.notifi();
        public forget_pass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string  email = textBox2.Text;
            string birth = dateTimePicker1.Text;
            account.database_load(name);
            string result=account.forget_Password(email,birth);
            if(result !=null)
            {
                MessageBox.Show("Your Passwod is sent");
                mail.sent_email_forget_pass(result,email,name);
                Form1 ff= new Form1();
                this.Hide();
                ff.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to recover due to invaild informantion above!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
