using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// LinkedStack class implementing stack using linked lists
/// </summary>
namespace Exam2
{
    class LinkedStack
    {
        public LinkedStackNode Head { get; set; }               // Contains first node
        public LinkedStackNode Tail { get; set; }               // Contains last node

        public int Count { get; set; }                          // Contains number of elements in stack

        /// <summary>
        /// Empty default constructor
        /// </summary>
        public LinkedStack() { }

        /// <summary>
        /// Add new node to stack
        /// </summary>
        /// <param name="data">Data to be added to stack</param>
        public void Push(string data)
        {
            if (this.Head == null)
            {
                this.Head = new LinkedStackNode(data);          // Create new head node
                this.Tail = this.Head;

                this.Count++;
            }
            else
            {
                this.Tail.Next = new LinkedStackNode(data);     // If head node exists, create next node
                this.Tail.Next.Previous = this.Tail;
                this.Tail = this.Tail.Next;

                this.Count++;
            }
        }

        /// <summary>
        /// Remove the top elements from the stack
        /// </summary>
        /// <returns>Top element in stack</returns>
        public string Pop()
        {
            string returnValue = null;

            if (Count == 0)                                     // If there are no elements in the stack
            {
                returnValue = "Error! Cannot Pop from an empty stack";
            }
            else
            {
                LinkedStackNode current = this.Tail;
                
                returnValue = current.Data;

                if (current.Previous != null)                   // If we are somewhere in the stack
                {
                    this.Tail = current.Previous;
                }
                else if (current.Previous == Head)              // If this is the last element in the stack
                {
                    this.Tail = this.Head;
                }
                else                                            // If there are no more elements in the stack
                {
                    this.Head = null;
                    this.Tail = null;
                }

                Count--;
            }

            return returnValue;
        }

        /// <summary>
        /// Retrieve the last/top element in the stack
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            string returnValue = null;

            if (Count == 0)                                     // If the stack is empty
            {
                throw new Exception("Cannot peek, the stack is empty");
            }
            else                                                // If the stack is not empty
            {                
                returnValue = this.Tail.Data;                
            }

            return returnValue;
        }

        /// <summary>
        /// Clear the stack by removing all nodes
        /// </summary>
        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Print all notes in the stack
        /// </summary>
        public void PrintStack()
        {
            if (Count == 0)                                     // If the stack is empty
            {
                Console.WriteLine("There is nothing to print, the Stack is empty");
            }
            else                                                // If the stack is not empty
            {
                LinkedStackNode current = Tail;

                for (int i = this.Count; i > 0; i--)
                {
                    Console.WriteLine(current.Data);

                    current = current.Previous;
                }
            }
        }
    }
}
