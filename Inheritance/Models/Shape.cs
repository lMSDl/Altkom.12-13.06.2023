using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //klasa abstrakcyjna - baza dla innych klas, nie można utworzyć jej instancji
    //każda klasa dziedziczy niejawnie po klasie Object
    internal abstract class Shape /*: Object*/
    {

        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return Name;
        }

        //metoda abstrakcyjna - nie posiada ciała i MUSI mieć implementację klasach pochodnych
        //jeśli klasa posiada jakąkolwiek metodę abstrakcyjną, to klasa ta też musi być abstrakcyjna
        public abstract void SomeAbstractMethod();

    }
}
