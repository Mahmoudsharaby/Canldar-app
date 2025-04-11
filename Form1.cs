using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        User.User_Preference account = new User.User_Preference();
        public static string user_name;
        public Form1()
        {
            InitializeComponent();
            //string folder= "C:\\Users\\mahmoud\\Desktop\\project\\WindowsFormsApp1\\bin\\Debug";
           // CreateShortCut(folder);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            user_name = s;
            string aa = account.database_load(s);
            if (aa == null)
            {
                MessageBox.Show("User is wrong or does not exist");
            }
            else
            {
                if (account.Login(textBox2.Text))
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signup f2 = new Signup();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forget_pass dd = new forget_pass();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }
        /*private void CreateShortCut(string folder)
        {
            var icon = new WshShell();
            string filename =folder+"\\"+ProductName+".lnk";
            IWshShortcut shortcut = (IWshShortcut)icon.CreateShortcut(filename);
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.Save();
        }*/
    }
}
