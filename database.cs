using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal class database
    {
        public class database_handeler
        {
            private static List<string> filenames = new List<string>();
            private  string[] list=new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            private  List <string> Check_file = new List<string>();
            static database_handeler()
            {
                string s;
                FileStream load = new FileStream("filenames.txt", FileMode.OpenOrCreate, FileAccess.Read);
                var reader = new StreamReader(load);

                while ((s = reader.ReadLine()) != null)
                {
                    filenames.Add(s);

                }
                reader.Close();
                load.Close();
                for (int i = 0; i < filenames.Count; i++)
                {
                    if (filenames[i] == " ")
                        filenames.RemoveAt(i);

                }

            }
           
            private int getindex(string filenamess)
            {
                return filenames.IndexOf(filenamess);
            }
            public void display()
            {
                string s;
                FileStream load = new FileStream("filenames.txt", FileMode.OpenOrCreate, FileAccess.Read);
                var reader = new StreamReader(load);
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
                load.Close();

            }
            private int checkif(string name)
            {
                int x = 1;
                for (int i = 0; i < filenames.Count; i++)
                {

                    if (filenames[i] != name)
                    {
                        x = 0;

                    }
                    else
                    {
                        x = 1;
                        break;
                    }
                }

                return x;
            }
            public bool add(string name)
            {
                if (checkif(name) == 1)
                {
                    return true;

                }
                else
                {
                    filenames.Add(name);
                    FileStream unload = new FileStream("filenames.txt", FileMode.Append, FileAccess.Write);
                    var writer = new StreamWriter(unload);
                    writer.WriteLine(name);
                    writer.Close();
                    unload.Close();
                    return false;

                }
            }
            public void adduser(string name, string pass, string brith, string email)
            {
                
                  
                FileStream vr = new FileStream(name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                  
                    var writer = new StreamWriter(vr);
                    writer.WriteLine(pass);
                    writer.WriteLine(brith);
                    writer.WriteLine(email);
                    writer.Close();
                    vr.Close();
                   

                
            }
            public void removeuser(string name)
            {

                File.Delete(name+".txt");
                File.Delete(name+"2.txt");


            }
            public void remove(string name)
            {

                filenames.RemoveAt(getindex(name));
                File.Delete("filenames.txt");
                FileStream vr = new FileStream("filenames.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(vr);
                for (int i = 0; i < filenames.Count; i++)
                {
                    writer.WriteLine(filenames[i]);
                }
                writer.Close();
                vr.Close();

            }
        
           
            public string[] loadclr(string name, string day,int year,int month)
            { 
                FileStream vr= new FileStream(name+day+month.ToString()+year.ToString()+".txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
                var reader = new StreamReader(vr);
                string s;
                int i = 0;
                while ((s=reader.ReadLine()) !=null&&i<18)
                {
                    list[i]=s;
                    i++;
                }
                reader.Close();
                vr.Close();
                return list;

            }
            public void addclr(string name, int day,int year,int month,string Event,string note,int num)
            {
                int j = 0;
                for (int i = 1; i < 10; i++)
                {
                    if (i == num)
                    {
                        list[j] = Event;
                        list[j+1] = note;
                        break;
                    }
                    j += 2;
                }
                File.Delete(name + day.ToString() + month.ToString() + year.ToString() + ".txt");
                FileStream vr = new FileStream(name+day.ToString()+month.ToString()+year.ToString()+".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(vr);
               
               for(int i=0;i<list.Length; i++) 
               {
                    writer.WriteLine(list[i]);
               }
               writer.Close();
               vr.Close();
               
            }
            public List<string> load_check(string name)
            {
                FileStream todo = new FileStream(name + "2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var reader=new StreamReader(todo);
                string s;
                while ((s=reader.ReadLine())!=null) 
                {
                    Check_file.Add(s);
                }
                todo.Close();
                return Check_file;
            }
            public void addtodo(string task,bool x, string name)
            {
                
                Check_file.Add(task);
                Check_file.Add(x.ToString());
                FileStream todo = new FileStream(name + "2.txt", FileMode.Append, FileAccess.Write);
                var writer = new StreamWriter(todo);
                writer.WriteLine(task);
                writer.WriteLine(x.ToString());
                writer.Close();
                todo.Close();

            }
            public void check_bool(string x, string task,string name)
            {
                for (int i = 0; i < Check_file.Count(); i++)
                {
                    if (Check_file[i] == task)
                    {
                        Check_file[i+1] = x;
                    }
                }
                File.Delete(name + "2.txt");
                FileStream todo = new FileStream(name + "2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(todo);
                for (int i = 0; i < Check_file.Count; i++)
                {
                    writer.WriteLine(Check_file[i]);
                }
                writer.Close();
                todo.Close();

            }
            public void removetodo(string name, string task,string x)
            {
                // delete file is better than this
                
                Check_file.Remove(x);
                Check_file.Remove(task);
                File.Delete(name+"2.txt");
                FileStream todo = new FileStream(name+"2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(todo);
                for (int i = 0; i <Check_file.Count; i++)
                {
                    writer.WriteLine(Check_file[i]);
                }
                writer.Close();
                todo.Close();
            }
            public string[] loaduser(string name) // was added to load the user data  
            {

                if (filenames.Contains(name))
                {
                    string[] arr = new string[3];
                    FileStream vr = new FileStream(name + ".txt", FileMode.Open, FileAccess.Read);
                    var reader = new StreamReader(vr);
                    string s;
                    int i = 0;
                    while ((s = reader.ReadLine()) != null)
                    {

                        arr[i] = s;
                        i++;
                    }

                    reader.Close();
                    vr.Close();
                    return arr;
                }
                else
                {
                    return null;
                }
            }
            public void edit_pass(string name,string pass,string email,string brith)
            {
                File.Delete(name+".txt");
                FileStream vr = new FileStream(name+".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(vr);
                writer.WriteLine(pass);
                writer.WriteLine(brith);
                writer.WriteLine(email);
                writer.Close();
                vr.Close();
            }



        }

    }

}
