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
    public partial class UserControl3 : UserControl
    {
        User.User_Preference account = new User.User_Preference();
        string name=Form1.user_name;
        notification.notifi mail=new notification.notifi();

        
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.database_load(name);
            mail.sent_email_delete(account.Email, name);
            account.delete_User();
            MessageBox.Show("The account is deleted");
            this.Hide();
            Application.Exit();
            

        }
    }
}
