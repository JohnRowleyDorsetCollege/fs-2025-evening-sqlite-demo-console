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

var student1 = new Student { Name = "John Doe", Age = 25 };
var student2 = new Student { Name = "Jane Doe", Age = 22 };

context.Students.Add(student1);
context.Students.Add(student2);
await context.SaveChangesAsync();

foreach (var student in context.Students)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
}   

