using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class MyCollectionClass : IEnumerable
    {
        List<Student> Students = new List<Student>();
        public void Add(Student s)
        {
            Students.Add(s);
        }

        public int Sum()
        {
            int sum = 0;
            foreach(Student person in Students)
            {
                sum = sum + person.Marks;
            }
            return sum;
        }

        public void Reverse()
        {
            int l = Students.Count();
            for(int i = l - 1; l >= 0; i--)
            {
                Console.WriteLine(Students[i].Marks);
            }
        }

        //public void SetReverse()
        //{
        //    int h = Students.Count;
        //    int l = 0;
        //    while (l < h)
        //    {
        //        var temp = Students[l];
        //        Students[l] = Students[h];
        //        Students[h] = temp;
        //        l = l + 1;
        //        h = h - 1;
        //    }
        //}

        public IEnumerator GetEnumerator()
        {
            return Students.GetEnumerator(); 
        }
    }
}
