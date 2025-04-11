using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Check_do : Form
    {
        Check_list.Checklist todo=new Check_list.Checklist();
        database.database_handeler save=new database.database_handeler();
        calender.Calendar date_today=new calender.Calendar();
        string name= Form1.user_name;
        List<string> list=new List<string>();
        bool is_editing;
        public Check_do()
        {
            InitializeComponent();
           dataGridView1.DataSource= todo.create_table();
            list=save.load_check(name);
            if (list.Count > 0)
            {
                for (int i = 0; i<list.Count; i += 2)
                {
                    todo.add_rows(list[i],list[i+1]);
                }

            }

            label2.Text = date_today.Day.ToString()+"/"+date_today.Month.ToString()+"/"+date_today.Year.ToString();
            
        }

        private void Check_do_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            is_editing = false;
            bool x=false;
            todo.add_rows(textBox1.Text,"false");
            save.addtodo(textBox1.Text,x,name);
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            is_editing = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string task= todo.To.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            string x= todo.To.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            save.removetodo(name,task,x);
            todo.To.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (is_editing)
            {
                string temp = todo.To.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
                string x = todo.To.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
                save.removetodo(name, temp,x); 
                todo.To.Rows[dataGridView1.CurrentCell.RowIndex]["Tasks"] = textBox1.Text;
                string task = textBox1.Text;
                save.addtodo( task, false, name);
                is_editing = false;
            }
            else
            {
                string x = todo.To.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
                save.check_bool(x, todo.To.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString(), name);
            }
            textBox1.Text = "";
            
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 ff= new Form2();
            this.Hide();
            ff.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
