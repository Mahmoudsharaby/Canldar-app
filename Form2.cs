
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
    public partial class Form2 : Form
    {
        static string s = Form1.user_name;
       
        public Form2()
        {
            InitializeComponent();
            label4.Text += s;
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Formcalndar ff= new Formcalndar();
            this.Hide();
            ff.ShowDialog();
           
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Check_do ff=new Check_do();
            this.Hide();
            ff.ShowDialog();
            this.Close();   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           settings ff = new settings();
            this.Hide();
            ff.ShowDialog();
            this.Close();

            
        }

        private void label4_ChangeUICues(object sender, UICuesEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
