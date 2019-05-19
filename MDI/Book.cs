using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    class Book
    {
        public String Name { get; set; }
        public String Author { get; set; }
        public DateTime Date { get; set; }

        public Book(string name, string author, DateTime date)
        {
            Name = name;
            Author = author;
            Date = date;
        }
    }
}
