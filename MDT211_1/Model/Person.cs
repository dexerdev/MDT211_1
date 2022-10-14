using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT211_1.Model
{
    class Person
    {
        protected string title;
        protected string firstname;
        protected string lastname;
        protected string age;
        protected string religion;
        protected string allergy;
        public Person(string title, string firstname, string lastname, string age, string religion, string allergy)
        {
            this.title = title;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.religion = religion;
            this.allergy = allergy;
        }
        public string GetFullName()
        {
            return this.title + " " + this.firstname + " " + this.lastname;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public string GetFirstName()
        {
            return firstname;
        }
        public string GetLastName()
        {
            return this.lastname;
        }

    }
    class PresentStudent : Person
    {
        private string StudentId;
        private string AdminFlag;
        private string Email;
        private string Password;
        public PresentStudent(string title, string firstname, string lastname, string age
            , string religion, string allergy, string studentId, string adminFlag, string email, string password)
            : base(title, firstname, lastname, age, religion, allergy)
        {
            this.StudentId = studentId;
            this.AdminFlag = adminFlag;
            this.Email = email;
            this.Password = password;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public string GetAdminFlag()
        {
            if (this.AdminFlag == "Y"){
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        public bool UserLogin(string email, string password)
        {
            if (this.Email.ToLower() == email.ToLower() && this.Password == password)
            {
                return true;

            }
            return false;
        }

    }
    class Student : Person
    {
        private string LevelOfEducation;
        private string School;
        public Student(string title, string firstname, string lastname, string age
            , string religion, string allergy, string LevelOfEducation, string School)
            : base(title, firstname, lastname, age, religion, allergy)
        {
            this.LevelOfEducation = LevelOfEducation;
            this.School = School;
        }
        public string GetLevelOfEducation()
        {
            string level = this.LevelOfEducation;
            return level;
        }
    }
    class Teacher : Person
    {
        private string position;
        private string haveCar;
        private string licenseno;
        private string AdminFlag;
        private string Email;
        private string Password;
        public Teacher(string title, string firstname, string lastname, string age
            , string religion, string allergy, string position, string haveCar, string licenseno
            , string AdminFlag, string Email, string Password)
            : base(title, firstname, lastname, age, religion, allergy)
        {
            this.position = position;
            this.haveCar = haveCar;
            this.licenseno = licenseno;
            this.AdminFlag = AdminFlag;
            this.Email = Email;
            this.Password = Password;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public string GetAdminFlag()
        {
            if (this.AdminFlag == "Y")
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        public bool UserLogin(string email, string password)
        {
            if (this.Email.ToLower() == email.ToLower() && this.Password == password)
            {
                return true;

            }
            return false;
        }
    }
}
