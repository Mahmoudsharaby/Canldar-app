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
    public partial class Events : UserControl
    {
       
        string name = Form1.user_name;
        database.database_handeler save_data = new database.database_handeler();
        int num,day,year,month;

        public Events(int eventnum)
        {
            InitializeComponent();
            num= eventnum;
        }
        public Events(string task1,string notes,int num,int day,int year,int month)
        {
            InitializeComponent();
            textBox1.Text = task1;
            richTextBox1.Text = notes;
            this.num = num;
            this.day = day;
            this.year = year;
            this.month = month;
            save_data.loadclr(Form1.user_name, day.ToString(), year, month);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            string n;
            s=textBox1.Text;
            n=richTextBox1.Text;
            save_data.addclr(Form1.user_name, day, year, month,s,n,num);
            MessageBox.Show("The data is saved!!");
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void remoov(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
