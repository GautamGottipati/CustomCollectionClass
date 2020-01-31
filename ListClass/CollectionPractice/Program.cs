using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class Program
    {
        public static int CompareName(Student firststudentname, Student secondstudentname)
        {
            return firststudentname.StudentName.CompareTo(secondstudentname.StudentName);
        }
        static void Main(string[] args)
        {
            // Created a Student Class and added 3 objects named first ,second, third
            Student first = new Student { Roll = 1, StudentName = "GAP", Marks = 100 };
            Student second = new Student { Roll = 2, StudentName = "REEBOK", Marks = 90 };
            Student third = new Student { Roll = 3, StudentName = "ADIDAS", Marks = 80 };
            List<Student> Students = new List<Student>();
            Students.Add(first);
            Students.Add(second);
            Students.Add(third);
            // Sorting based on the roll numbers of students( due to  IComparable)
            Students.Sort();
            foreach (Student s in Students)
            {
                Console.WriteLine(s.Roll + " " + s.StudentName + " " + s.Marks);
            }
            CompareStudents obj = new CompareStudents();
            // Naive method for delegates
            Comparison<Student> obj1 = new Comparison<Student>(CompareName);
            Students.Sort(obj1);
            
            // Sorting using Delegate Comparision => you can directly pass method name because the method name matches with the signature of delegare
            Console.WriteLine("Sorting using Delegate Comparision");
            //Students.Sort(CompareName);

            // Method 2 Anonymous method 
            //Students.Sort(delegate (Student s1, Student s2) { return s1.StudentName.CompareTo(s2.StudentName); }) ;
            foreach(Student s in Students)
            {
                Console.WriteLine(s.Roll + " " + s.StudentName + " " + s.Marks);
            }

            MyCollectionClass myarray = new MyCollectionClass();
            myarray.Add(first);
            myarray.Add(second);
            myarray.Add(third);
            foreach(Student s in myarray)
            {
                Console.WriteLine(s.Marks);
            }

            //Console.WriteLine("Sum of marks is "+ myarray.Sum());

            //Console.WriteLine("Printing Reverse of Marks. . .");
            ////myarray.SetReverse();
            //myarray.Reverse();

            //Console.ReadKey();
            ///////////////////////////////////////////////////
            // Custom Collection Class    /////////////////////
            ///////////////////////////////////////////////////
            Console.WriteLine("New class");
            CustomClass myClass = new CustomClass(10);
            myClass.Add(20);
            myClass.Reverse();
            myClass.Display();
            
            Console.WriteLine("Sum of elements in an Array is {0}\n and total elements are {1}", myClass.Sum(),myClass.Count());
            Console.ReadKey();
        }
    }
}
