using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
   public class Worker : Human
   {
       private decimal weekSalary;
       private decimal workHoursPerDay;

       public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) 
            : base(firstName, lastName)
       {
           this.WeekSalary = weekSalary;
           this.WorkHoursPerDay = workHoursPerDay;
       }

       public decimal WeekSalary
       {
           get { return this.weekSalary; }
           set
           {
               if (value < 0 )
               {
                   throw new ArgumentOutOfRangeException("Week sa" + "lary must be positive number");
               }
               this.weekSalary = value;
           }
       }

        public decimal WorkHoursPerDay {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be positive number");
                }
                this.workHoursPerDay = value;
            }
       }


       public decimal MoneyPerHour()
       {
           return weekSalary/(WorkHoursPerDay*7m);
        }
   }
}
