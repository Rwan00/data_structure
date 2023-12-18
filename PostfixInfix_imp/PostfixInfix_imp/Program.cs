using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostfixInfix_imp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackNode S = new StackNode();
         
           
            
            string exp = "a+b*(c^d-e)^(f+g*h)-i";
            Console.WriteLine(infixToPostfix( exp));
            
        }
    }
}
