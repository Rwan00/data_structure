using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            Console.WriteLine(q.empty());
            Console.WriteLine(q.full());

            q.enqueue(5); //5
            q.enqueue(9); //5,9
            Console.WriteLine(q.empty());

            Console.WriteLine(q.dequeue()); //9 in queue

            q.enqueue(13); // 9,13
            q.enqueue(10); // 9,13,10

            int x = q.dequeue();
            Console.WriteLine(x); // 13,10

             x = q.dequeue();
            Console.WriteLine(x); //10

            x = q.dequeue();
            Console.WriteLine(x); //0

            x = q.dequeue();
            Console.WriteLine(x);

        }
    }
}
