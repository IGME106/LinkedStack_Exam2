using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Single node
/// </summary>
namespace Exam2
{
    class LinkedStackNode
    {
        public string Data { get; set; }
        public LinkedStackNode Previous { get; set; }
        public LinkedStackNode Next { get; set; }

        /// <summary>
        /// Constructor for node
        /// </summary>
        /// <param name="data"></param>
        public LinkedStackNode(string data)
        {
            this.Data = data;
            this.Previous = null;
            this.Next = null;
        }

    }
}
