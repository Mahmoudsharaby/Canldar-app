using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Check_list
    {
        public class Checklist
        {
            private DataTable todo = new DataTable();
            public DataTable To { get { return todo; } }
            public DataTable create_table()
            {
                todo.Columns.Add("Tasks");
                todo.Columns.Add("Completed", System.Type.GetType("System.Boolean"));
                return todo;
            }
            public void add_rows(string task,string x)
            {
                todo.Rows.Add(task,Convert.ToBoolean(x));
            }

        }
    }
}
