using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Parameters passed from command line</param>
        static void Main(string[] args)
        {
            LinkedStack myStack = new LinkedStack();

            myStack.Push("A");
            myStack.Push("B");
            myStack.Push("C");
            myStack.Push("D");

            Console.WriteLine("Top of the stack is " + myStack.Peek());
            Console.WriteLine("The count is now " + myStack.Count);
            Console.WriteLine("Contents of the stack are :");
            myStack.PrintStack();
            Console.WriteLine();
            Console.WriteLine("Popped " + myStack.Pop());
            Console.WriteLine("Popped " + myStack.Pop());
            Console.WriteLine();
            Console.WriteLine("Top of the stack is " + myStack.Peek());
            Console.WriteLine("The count is now " + myStack.Count);
            Console.WriteLine("Contents of the stack are :");
            myStack.PrintStack();
            Console.WriteLine();
            Console.WriteLine("Popped " + myStack.Pop());
            Console.WriteLine("Popped " + myStack.Pop());
            Console.WriteLine();
            try
            {
                Console.WriteLine("Popped " + myStack.Pop());
            } catch(Exception e) { Console.WriteLine("Recieved error: " + e.Message); }

            Console.WriteLine();

            try
            {
                Console.WriteLine("Top of the stack is :" + myStack.Peek());
            }
            catch (Exception e)
            {
                Console.WriteLine("Recieved error: " + e.Message);
            }
    Console.WriteLine("The count is now :" + myStack.Count);
            Console.WriteLine("Contents of the stack are :");
            myStack.PrintStack();

            myStack.Push("E");
            myStack.Push("F");

            Console.WriteLine();
            Console.WriteLine("Top of the stack is " + myStack.Peek());
            Console.WriteLine("The count is now " + myStack.Count);
            Console.WriteLine("Contents of the stack are :");
            myStack.PrintStack();

            Console.WriteLine();
            Console.WriteLine("Clearing the stack");
            myStack.Clear();

            Console.WriteLine();
            Console.WriteLine("The count is now " + myStack.Count);

            Console.ReadLine();

        }
    }
}
