using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ImpArray
{
    public class Stackk
    {

        private int[] arr = new int[3];
        private int TopIndex = -1;

        public void push(int s)
        {
            if (TopIndex == arr.Length - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;

            }
            else
            {
                TopIndex++;
                arr[TopIndex] = s;
            }


        }
        public int pop()
        {

            if (TopIndex == -1)
            {
                Console.WriteLine("Stack is empty!!");
                return -1;
            }
            else
            {
                int v = arr[TopIndex];

                v = arr[TopIndex--];
                Console.WriteLine("Element poped: " + v);

                return v;
            }

        }
        public void print()
        {
            if (TopIndex == -1)
            {
                Console.WriteLine("Stack is empty!!");

            }
            else
            {
                for (int i = 0; i <= TopIndex; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }


      
    }
}








                    
