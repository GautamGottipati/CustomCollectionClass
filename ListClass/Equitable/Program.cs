using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equitable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("GEVE", "Geert Verhoeven");

            ArrayList employees = new ArrayList();
            employees.Add(emp1);

            Employee emp2 = new Employee("GEVE", "Geert");

            // SCENARIO 1: Comparing with an object from the same class.

            Console.WriteLine("emp1.Equals(emp2): {0}", emp1.Equals(emp2));


            // SCENARIO 2: Comparing with an object from a different class.

            Object obj = emp2;
            Console.WriteLine("emp1.Equals(obj): {0}", emp1.Equals(obj));


            // SCENARIO 3: Using an ArrayList (analog to SCENARIO 2)

            Console.WriteLine("employees.Contains(emp2): {0}",
                employees.Contains(emp2));

            Console.ReadLine();
        }
    }
}
