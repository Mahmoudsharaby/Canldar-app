using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class day_tab : UserControl

    {
        database.database_handeler event_data=new database.database_handeler();
        calender.Calendar obj =new calender.Calendar();
        string name=Form1.user_name;
        private int year_data, month_data;
           private string  day_data,temp_day;

        string[] arr = new string[18];
        public day_tab(int year, int month, string day)
        {
            InitializeComponent();
            checkBox1.Hide();
            Event1.Hide();
            Event2.Hide();
            Event3.Hide();
            year_data = year;
            month_data = month;
            day_data = day;
            temp_day= day;
            arr = event_data.loadclr(name, day_data, year_data, month_data);
            if (day == obj.Day.ToString() && year == obj.Year && month == obj.Month)
            {
                label1.Text = day;
                label1.ForeColor = Color.Crimson;
            }
            else
            {
                label1.Text = day;
            }
            if (arr[0] != "" && arr[0] != "0")
            {
                Event1.Show();
                Event1.Text = arr[0];
            }
            if (arr[2] != "" && arr[2] != "0") 
            { 
                Event2.Show();

                Event2.Text = arr[2];
                if (arr[4] != "" && arr[4]!= "0")
                {
                    Event3.Show();
                    Event3.Text = "......";

                }
            }
        }

       

        private void Day_tab(object sender, EventArgs e)
        {

        }

        private void Clk(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.Black;
                event_data.loadclr(name, day_data, year_data, month_data);
                eventcalndar Ev = new eventcalndar(year_data,month_data,Convert.ToInt32(temp_day));
                Ev.ShowDialog();
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        private void Event1_Click(object sender, EventArgs e)
        {

        }
    }
}
