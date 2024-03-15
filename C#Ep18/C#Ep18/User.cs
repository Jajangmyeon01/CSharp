using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C_Ep18
{
    internal class User
    {

        #region -- Private Attributes / Fields 
        /*
        private int userID;
        private string firstName;
        private string lastName;
        private int age;

        #endregion

        #region -- Properties --
        public int UserID
        {
            get { return userID; }
            set {
                Console.Write("Enter User Id : ");
                Console.ReadLine();
                if (value >= 1000) userID = value;
                else Console.WriteLine("Error it must not below 1000");               
            }
        }
        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }  
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string FullName
        {
            get { return $"FullName : {firstName + " " + LastName}";}
        }
        */


        #region -- Constructor --
        /*
        public User (int userId, string firstName, string lastName, int age)
        {  
            UserID = userId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        */
        #endregion

        #endregion

        #region -- Automatic Properties --

        public string studentName { get; set; }
        public string passWord { get; set; }       
        public string email { get; set; }
        public int postalCode { get; set; }


        public User(string studentName, string passWord, string email, int talCode)
        {
            this.studentName = studentName;
            this.passWord = passWord;
            this.email = email;
            this.postalCode = talCode;
        }
        #endregion

    }
}
