using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice 
{
    /// <summary>
    /// THis is a students class which implements the interface IComparable
    /// </summary>
    class Student : IComparable<Student>
    {
        public int Roll
        {
            get;
            set;
        }
        public int Marks
        {
            get;
            set;

        }
        public string StudentName
        {
            get;
            set;
        }

        public int CompareTo(Student obj)
        {
            if (this.Roll > obj.Roll)
                return 1;
            else if (this.Roll < obj.Roll)
            {
                return -1;
            }
            else
                return 0;
        }
    }

    /// <summary>
    /// This is a CompareStudents which implements IComparer interface 
    /// This is responsible for the Students class to sort according to Marks.
    /// </summary>

    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
}
