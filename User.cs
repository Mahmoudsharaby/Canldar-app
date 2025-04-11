using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.database;
using System.IO;

namespace WindowsFormsApp1
{
     internal class User
    {
        public abstract class User_account
        {
            
            protected string User_Name { get; set; }
            public string Email { get; set; }
            protected string Password { get; set; }
            protected string Birthdate { get; set; }

            protected database.database_handeler pr = new database.database_handeler();


            public User_account() { }
            //Display user information : retrieved from data base
            public virtual void DisplayUser()
            {
                Console.WriteLine("User  Name: " + User_Name);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("Birthdate: " + Birthdate);
            }
            //Login method to check if the entered email and password match the database records
            public abstract string database_load(string s);
           
            public abstract bool Login(string password);
            
        }

        public class User_Preference : User_account
        {

            public override string database_load(string s)
            {
                // to load the user from the database
                string[] arr = pr.loaduser(s);
                User_Name = s;
                if (arr != null)
                {
                    Password = arr[0];
                    Birthdate = arr[1];
                    Email = arr[2];
                    return "1";
                }
                else
                { return null; }

            }
            //Database users need to be created
            public bool Create_User(string name, string email, string date, string pass)
            {
               
               User_Name = name;
                Email = email;
                Password = pass;
                Birthdate = date;
                bool ff=pr.add(User_Name);
                if (ff==true)
                {
                    return true;

                }
                else
                {
                    pr.adduser(User_Name, Password, Birthdate, Email);
                    return false;
                }
                
            }
            public static void Display_User(User_account user)
            {
                user.DisplayUser();
            }

            //Login Database records may be created if needed
            public override bool Login(String pass)
            {
                return Password == pass;

            }

            //Compares the entered password with the current password in database and changes it
            public bool change_Password(string current_password,string new_password)
            {
               

                if (current_password == Password)
                {
                    Password = new_password;
                   pr.edit_pass(User_Name,Password,Email,Birthdate);    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Retrieve user password from Database and changes it 
            public string forget_Password(string email,string birth)
            {

                if (email == Email && birth == Birthdate)
                {
                    return Password;
                }
                else
                {
                    return null;
                }
               

            }


            //Delete user account from Database
            public  void delete_User()
            {
                pr.removeuser(User_Name);
                pr.remove(User_Name);
            }

        }
    }

}
