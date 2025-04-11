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

    public partial class eventcalndar : Form
    {
        database.database_handeler data_get=new database.database_handeler();
        string name=Form1.user_name;
        public int num =1;
        int year_data,month_data,day_data;
        string[] arr=new string[18];

        public eventcalndar(int year,int month,int day)
        {
            InitializeComponent();
            TEvent.Text= day.ToString()+"/"+month.ToString()+'/'+year.ToString();
            year_data = year;   
            month_data = month;
            day_data = day;
             arr = data_get.loadclr(name, day_data.ToString(), year_data, month_data);
            if (arr != null)
            {
                for (int i = 0; i < arr.Length - 1; i+=2)
                {
                    if ((arr[i] != "0")&& (arr[i] != ""))
                    {
                        
                        var events = new Events(arr[i], arr[i + 1], num, day_data, year_data, month_data);
                        num++;
                        flowLayoutPanel1.Controls.Add(events);
                        flowLayoutPanel1.Controls.Add(pictureBox1);
                        
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(pictureBox1);
                    }
                }
            }
            else
            {
                flowLayoutPanel1.Controls.Add(pictureBox1);
            }
        }

        private void event_load(object sender, EventArgs e)
        {
           
        }

        private void boom(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var events = new Events(" "," ",num,day_data,year_data,month_data);
            num++;
            flowLayoutPanel1.Controls.Add(events);
            flowLayoutPanel1.Controls.Add(pictureBox1);
        }
        private void confirm_click(object sender, EventArgs e)
        {
           
            this.Hide();
            this.Close();
        }
    }
}
