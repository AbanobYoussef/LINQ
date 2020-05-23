using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    class Program
    {
        static void Main(string[] args)
        {


            //List<string> Names = new List<string>()
            //{
            //    "Red","Book","Computer","Mobile",
            //    "Program","Driver","Windows",
            //    "Key","Home","Pen","Right",
            //    "Play","Clic","Languge","Rule",
            //    "Peace","Word","file"
            //};



            //Book[] books =
            //{
            //    new Book() {Id=6, Title="C#", Author="A"} , 
            //    new Book() {Id=7, Title="java", Author="B"} , 
            //    new Book() {Id=4, Title="Prel", Author="C"} , 
            //    new Book() {Id=7, Title="Android", Author="D"} , 
            //    new Book() {Id=8, Title="Python", Author="E"} , 
            //    new Book() {Id=8, Title="PHP", Author="F"} , 
            //    new Book() {Id=7, Title="Ruby", Author="G"} , 
            //};



            //Teacher[] teachers =
            //{
            //    new Teacher() {Name="A"} , 
            //    new Teacher() {Name="B"} , 
            //    new Teacher() {Name="C"} , 
            //    new Teacher() {Name="D"} , 
            //    new Teacher() {Name="E"} , 
            //    new Teacher() {Name="F"} , 
            //    new Teacher() {Name="G"} , 
            //};



            //Student[] students =
            //{
            //    new Student() {Name="A"} , 
            //    new Student() {Name="B"} , 
            //    new Student() {Name="C"} , 
            //    new Student() {Name="D"} , 
            //    new Student() {Name="E"} , 
            //    new Student() {Name="F"} , 
            //    new Student() {Name="G"} , 
            //};

            //string[] group1 = { "Khalid", "Hamid", "Yasser", "Kamal" };
            //string[] group2 = { "Youness", "Hamid", "Ayoub", "Khalid" }; 


            //string[] Names = {
            //                      "Red","Book","Computer","Mobile",
            //                      "Program","Driver","Windows","Key",
            //                      "Home","Pen","Right","Play","Clic",
            //                      "Languge","Rule","Peace","Word","file"
            //                 };

            //int[] numbers = { 4, 5, 7, 2, 8 };

            //var count = numbers.Count();
            //var count = numbers.Sum();
            //var count = numbers.Max();
            //var count = numbers.Min();
            //var count = numbers.Average();
            //Console.WriteLine(count);

            // Query Syntax

             //var Result = from item in Names select item;

             //var Result = from item in Names where item.Length > 3 select item;

            //var Result = from item in Names
            //             where item.StartsWith("R") && item.Length == 3
            //             select item;



            //var Result = from item 
            //             in books 
            //             orderby item.Id //ascending //descending 
            //             select item;



            //var Result = from item
            //             in books
            //             orderby item.Id , item.Title //ascending //descending 
            //             select item;


            //var Result = from item
            //             in books
            //             group item by item.Id;



            //var Result = from teacher in teachers
            //             join student in students
            //             on teacher.Name equals student.Name
            //             select teacher;

//------------------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------

            // Non-Query Syntax , Fluent Syntax , Method Syntax

             //var Result = Names.Where(item => item.Length > 3 );

            //var Result = Names.Where(item => item.Contains("P")).Take(2); // Take(number of elements requirted 

            //var Result = books.OrderBy(item => item.Id);

            //var Result = books.OrderByDescending(item => item.Id);  


            //var Result = books.OrderBy(item => item.Id).ThenBy(item => item.Title);


            //var Result = books.OrderBy(item => item.Id).ThenByDescending(item => item.Title);  


            //var Result = books.GroupBy(item => item.Id);  


            //var Result = group1.Concat(group2).Distinct(); // = var Result = group1.Union(group2);  



            //var Result = group1.Intersect(group2);  // same in g1 and g2


            //var Result = group1.Except(group2);   // existe in g1 and not existe in g2


            //var Result = teachers.Join(students,
            //                           tName => tName.Name, 
            //                           sName => sName.Name,
            //                           (tName,sName)=> tName);





           // var name = Names.First();

           // var name = Names.First(a => a.StartsWith("P"));
           //var name = Names.FirstOrDefault(a => a.StartsWith(" "));
           //Console.WriteLine(name==null);


            //var name = Names.Last();
            //var name = Names.Last(a => a.StartsWith("P"));
            //var name = Names.LastOrDefault(a => a.StartsWith(" "));
            //Console.WriteLine(name==null);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine("Id : " + item.Key);
            //    foreach (var book in item)
            //    {
            //        Console.WriteLine("{\n  Id = " + book.Id + " \n  Title = " + book.Title + " \n  Author = " + book.Author + " \n}\n");

            //    }
            //    Console.WriteLine("-----------------------------------------------------------------------------------------------");

            //}

            //foreach (var item in Result)
            //{
            //    Console.WriteLine("\n  Name = " + item.Name);
            //}


            //foreach (var item in Result)
            //{
            //    Console.WriteLine( item);
            //}

            Console.ReadKey();
        }
    }
}
