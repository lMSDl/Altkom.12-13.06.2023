using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal abstract class Shape2D : Shape1D
    {
        public Shape2D(string name, int width, int height) : base(name, width)
        {
            Height = height;
        }

        public int Height { get; set; }

        public override string ToString()
        {
            //base - odwołanie do wersji metody z klasy bazowej
            return $"{base.ToString()} i szerokości {Height}";
        }
    }
}
