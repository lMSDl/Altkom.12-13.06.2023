using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    // : - dziedziczenie (shape1D dziedziczy po shape)
    internal abstract class Shape1D : Shape
    {
        //wykorzystujemy konstruktor klasy bazowej poprzez odwołanie do base
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        public int Width { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} o długości {Width}";
        }

        //override - nadposujemy motodę z klasy bazowej
        public override void SomeAbstractMethod()
        {
            Console.WriteLine("Hello!");
        }
    }
}
