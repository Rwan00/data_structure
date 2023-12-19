using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_ArrayList
{
    internal class Program
    {
        class CircularQueue
        {
            private ArrayList arr = new ArrayList();
            private int front;
            private int rear;
            private int count;

            public CircularQueue()
            {
               
                front = 0;
                rear = -1;
              
                count = 0;
            }
            public void insert( object item)
            {
                
                
                    rear = (rear + 1) ;
                    arr.Add(item);

                    count++;
                
            }

            public void delete()
            {
                if (count == 0)
                {
                    Console.WriteLine("Queue is Empty");
                }
                else
                {
                    Console.WriteLine("deleted element is: " + arr[front]);

                    front = (front + 1) ;

                    count--;
                }
            }

            public void printQueue()
            {
                int i = 0;
                int j = 0;

                if (count == 0)
                {
                    Console.WriteLine("Queue is Empty");
                    return;
                }
                else
                {
                    for (i = front; j < count;)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]: " + arr[i]);

                        i = (i + 1) ;
                        j++;

                    }
                }
            }
        }


        static void Main(string[] args)
        {
            CircularQueue Q = new CircularQueue();

            Q.insert("souhaila");
            Q.insert(20.5);
            Q.insert(true);
            Q.insert(40);
            Q.insert(50);

            Console.WriteLine("Items are : ");
            Q.printQueue();
            
            Q.delete();
            Q.delete();

            Q.insert(60);
            Q.insert(70);

            Console.WriteLine("Items are : ");
            Q.printQueue();
            

        }
    }
}
