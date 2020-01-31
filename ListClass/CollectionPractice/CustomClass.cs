using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// This is a customclass
    /// It contains methods [Add,Display,Reverse,Sum,Count]
    /// </summary>
    class CustomClass : IEnumerable
    {
        Node head;
        Node temp;
        public CustomClass()
        {
            head = new Node();
        }
        public CustomClass(int data)
        {
            head = new Node(data);
        }
        public void Add(int data)
        {
            
            temp = head;
            while (temp.next!=null)
            {
                temp = temp.next;
            }
            temp.next = new Node(data);
            
        }
        public void Display()
        {
            temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Reverse()
        {
            Node prevnode = null, current = head, nextnode = null;
            while(current != null)
            {
                nextnode = current.next;
                current.next = prevnode;
                prevnode = current;
                current = nextnode;
            }
            head = prevnode;
        }
        public int Sum()
        {
            temp = head;
            int adder = 0;
            while(temp != null)
            {
                adder = adder + temp.data;
                temp = temp.next;
            }
            Console.WriteLine(adder);
            return adder;
        }

        public int Count()
        {
            temp = head;
            int count = 0;
            while (temp != null)
            {
                count = count + 1;
                temp = temp.next;
            }
            return count;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
