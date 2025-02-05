// See https://aka.ms/new-console-template for more information
using fs_evening_sqlite_demo_console;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
SQLitePCL.Batteries_V2.Init();

var options = new DbContextOptionsBuilder<AppDbContext>()
           .UseSqlite("Data Source=c:/sqlite/students20250205a.db")
           .Options;


var context = new AppDbContext(options);   

var student1 = new Student { Name = "John Doex1", Age = 25 };
var student2 = new Student { Name = "Jane Doex1", Age = 22 };

context.Students.Add(student1);
context.Students.Add(student2);
await context.SaveChangesAsync();

foreach (var student in context.Students)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
}



var movie1 = new Movie { Name = "Movie 11", Year = 1970 };
var movie2 = new Movie { Name = "Movie 21", Year = 1986 };

context.Movies.Add(movie1);
context.Movies.Add(movie2);
await context.SaveChangesAsync();

foreach (var movie in context.Movies)
{
    Console.WriteLine($"Id: {movie.Id}, Name: {movie.Name}, Age: {movie.Year}");
}


var book1 = new Book { Name = "Book 1", Author = "auth12" };
var book2 = new Book { Name = "Book 2", Author = "auth4" };

context.Books.Add(book1);
context.Books.Add(book2);
await context.SaveChangesAsync();

foreach (var book in context.Books)
{
    Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Age: {book.Author}");
}

