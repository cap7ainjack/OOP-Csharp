using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace _1_Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;


        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (String.IsNullOrEmpty(value) )
                {
                    throw new ArgumentException("Name not entered");
                }
                this.name = value ;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
               
                if (value > 120 || value < 0)
                {
                    throw new ArgumentException("Invalid age");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            set
            {
                if (!string.IsNullOrEmpty(value) && !IsValid(value)) // !value.Contains("@"))
                {
                    throw new ArgumentException("Email not valid");
                }
                this.email = value;
            }

            //  set
            //   {
            //       string pattern = @"(?<!@)\b\w+\b@(?!\W)\w+\.\w{0,3}";
            //        Regex regex = new Regex(pattern);

            //       // && !value.Contains("@")
            //        if (value != null && !regex.IsMatch(value))
            //       {
            //            throw new ArgumentException("Invalid E-mail adress!");
            //       }
            //       this.email = value;
            //   }
        }

      
        public override string ToString()
        {
            return string.Format("NAME: {0} AGE: {1} E-MAIL: {2}", this.Name, this.Age, 
                                string.IsNullOrEmpty(this.Email) ? " - " : this.Email);
        }

        private bool IsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
