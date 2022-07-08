using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparerIcompareableDemo
{
    internal class Student : IComparable<Student>   
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public float Marks { get; set; }

        public int CompareTo(Student other)
        { 
            //for simple sort
            if (this.Id>other.Id)

                return 1;
            else if (this.Id < other.Id)
                return -1;
            else 
                return 0;


            //for reverse sort
            //if (this.Id > other.Id)
            //    return -1;
            //else if (this.Id < other.Id)
            //    return 1;
            //else
            //    return 0;

        }
    }

    internal class StudCompare : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
            {
                return 1;
            }
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
}
