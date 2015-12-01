using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_EXR_Inheritans_Abastraction
{
     public class book
    {
        private string title;
        private string author;
        private decimal price;

         public book(string title, string author, decimal price)
         {
             this.Author = author;
             this.Title = title;
             this.Price = price;
         }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Title cannot be nameless");
                }
                this.title = value;
            } 
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Author field is mandatory");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new OverflowException("Price can`t be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}" +
                                "-Title: {2}{3}" +
                                "-Author: {4}{5}" +
                                "-Price: {6}", this.GetType().Name, Environment.NewLine,
                this.Title, Environment.NewLine,
                this.Author, Environment.NewLine,
                this.Price
                );

            return output.ToString();
        }
    }
}
