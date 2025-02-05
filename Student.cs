using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs_evening_sqlite_demo_console
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

    }


    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Year { get; set; }

    }

    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Author { get; set; }

    }
}
