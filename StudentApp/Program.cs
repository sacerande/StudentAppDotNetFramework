using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Database;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (dbStudent db = new dbStudent())
            {
                var lst = db.student.SqlQuery("select tab1.*, tab2.* from student tab1 inner join subjects tab2 on tab1.id = tab2.studid").ToList();
                foreach(var stud in lst)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Student FirstName {stud.firstname} LastName {stud.lastname} has following subjects...");
                    foreach(var sub in stud.subjects)
                    {
                        Console.WriteLine($"Subject ID: {sub.id}, Subject Name: {sub.subName}");
                    }
                    Console.WriteLine("----------------------------");
                }
            }
            Console.ReadLine();
        }
    }
}
