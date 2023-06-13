using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Square : Shape2D
    {
        public Square(int size) : base("Kwadrat", size, size)
        {
        }
    }
}
