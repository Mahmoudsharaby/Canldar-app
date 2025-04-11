using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formcalndar : Form
    {
        calender.Calendar obj = new calender.Calendar();
        public int Month = 0, Year = 0;
        public Formcalndar()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showdays(obj.Month, obj.Year);
        }
        private void PreB_Click(object sender, EventArgs e)
        {
            obj.Pre(ref Month, ref Year);
            showdays(Month, Year);
        }

        private void NextB_Click(object sender, EventArgs e)
        {
            obj.Next(ref Month, ref Year);
            showdays(Month, Year);
        }
        private void showdays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            Month = month;
            Year = year;
            T_month.Text = obj.Month_Name(month) + " " + year;
            for (int i = 1; i <= obj.First_Day(year, month); i++)// to reach the first day place before filling in the caldnar
            {
                day_tab tab = new day_tab(year,month,"");
                flowLayoutPanel1.Controls.Add(tab);
            }
            for (int i = 1; i <= obj.Month_Length(year, month); i++)
            {
                day_tab tab = new day_tab(year, month,i.ToString());
                flowLayoutPanel1.Controls.Add(tab);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Formcalndar ff= new Formcalndar();
            this.Hide();
            ff.ShowDialog();
            this.Close();
            
        }

        private void Home_Screen_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            this.Hide();
            ff.ShowDialog();
            this.Close();
        }

    }
}
