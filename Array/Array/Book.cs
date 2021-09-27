using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Book
    {
        string name;
        string author;
        double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author 
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //public Book() { }

        public Book(string name, string author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }
        public void Show() {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }



    }
}

