using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// This is Node class
    /// It contains two field Data and Next
    /// </summary>
    class Node
    {
        public int data;
        public Node next;
        public Node()
        {

        }
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
