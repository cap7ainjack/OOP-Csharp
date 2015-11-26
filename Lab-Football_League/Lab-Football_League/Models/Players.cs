using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Football_League.Models
{
   public class Players
   {
       private const int MinimumAllowedYear = 1980;
       private string firstName;
       private string lastName;
       private DateTime dateOfBirth;
       private decimal salary;
       private Teams team;

       public Players(string firstName, string lastName, DateTime dateofbirth, decimal salary,
           Teams team)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
           this.DateOfBirth = dateofbirth;
           this.Salary = salary;
           this.Team = team;
       }

       public string FirstName
       {
           get { return this.firstName; }

           set
           {
               if (value.Length < 3 || string.IsNullOrWhiteSpace(value))
               {
                   throw new ArgumentException("First name must be at least 3 letters long");
               }

               this.firstName = value;
           }
       }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (value.Length < 3 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name must be at least 3 letters long");
                }

                this.lastName = value;
            }
        }

       public DateTime DateOfBirth
       {
           get { return this.dateOfBirth; }
           set
           {
               if (value.Year < MinimumAllowedYear)
               {
                   throw new ArgumentException($"Player cannot be born before {MinimumAllowedYear}, sorry!");
               }
           }
       }

       public decimal Salary
       {
            get { return this.salary; }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentException("Salary must be positive number!");
               }
               this.salary = value;
           }
       }

       public Teams Team
       {
            get { return this.team; }
            set { this.team = value; }
       }

       public override string ToString()
       {
           return $"{this.FirstName} {this.LastName} ({this.Salary} p/w)";
       }
   }
}
