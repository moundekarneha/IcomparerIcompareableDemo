using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparerIcompareableDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student s1 =new Student { Id = 1, Name = "Neha", Marks = 90.0f };
            Student s2 =new Student { Id = 2, Name = "Pranita", Marks = 20.0f };
            Student s3 =new Student { Id = 8, Name = "Payal", Marks = 50.0f };
            Student s4 =new Student { Id = 4, Name = "sneha", Marks = 80.0f };

            List<Student> l2 = new List<Student>() { s1, s2, s3, s4 };

            StudCompare obj = new StudCompare();
            //l2.Sort(obj);
            l2.Sort(1,2,obj); //1 and 4 will skip and will sort 2-3
            //l2.Sort(); - sort based on Id 
            //l2.Reverse();
            foreach (var item in l2)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Name = " + item.Name);
                Console.WriteLine("Marks = " + item.Marks);

            }

            Console.ReadLine();
        }

    }
}
