using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    internal class Queue
    {
        private int first = -1;
        private int last = -1;
        private int[] arr = new int[10];

        public Boolean empty()
        {
            return first == last;

        }

        public Boolean full()
        {
            return last == arr.Length - 1;
        }

        public void enqueue (int v)
        {
            if (this.full())
            {
                Console.WriteLine("Queue is full!!");
            }
            else
            {
                last++;
                arr[last] = v;
            }
            
        }

        public int dequeue()
        {
            if (this.empty())
            {
                Console.WriteLine("Queue is empty!!");
                return -1;
            }
            else
            {
                first++;
                return arr[first];
            }
            
        }

    }
}
