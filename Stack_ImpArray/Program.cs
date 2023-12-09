using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ImpArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stackk MyStack = new Stackk();

            MyStack.push(5);
            MyStack.push(9);
            MyStack.push(3);

            MyStack.pop();


            MyStack.print();


          


        }
    }
}
