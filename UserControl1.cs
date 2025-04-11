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
    public partial class UserControl1 : UserControl
    {
        string name=Form1.user_name;
        User.User_Preference account= new User.User_Preference();
       
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = account.database_load(name);
            string current=textBox1.Text;  
            string new_pass=textBox2.Text;
           bool v= account.change_Password(current,new_pass);
            if (v==true)
            {
                MessageBox.Show("The password is changed");
            }
            else
            {
                MessageBox.Show("Failed to change the Password!");
            }
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
