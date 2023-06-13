using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa 
namespace ConsoleApp.Models
{
    //public / internal - modyfikator dostępu. public - klasa dostępna wszędzie, internal - klasa dostępna tylko w projekcie w którym sama się znajduje
    //class - szablon opisujący zachowania i wartości obiektów (instancji klas), które są wytwarzane na jej postawie
    //nazwa klasy: pełna nazwa klasy to namespace + nazwa
    public class Item
    {
        //prywatna zmienna globalna / pole
        //brak modyfikatora dostępu == private - dosęp tylko dla klasy w której jest zadeklarowana
        private int value;

        //getter do pobierania wartości pola - metoda zwracająca typ zgodny z typem pola
        //nazwa to zazwyczaj Get + nazwa pola
        public int GetValue()
        {
            //return - kończy metodę i zwraca wartość (obowiązkowy gdy metoda nie jest void) 
            return value;
        }

        //setter do ustawiania wartości pola - metoda przyjmująca parametr o typie zgodnym z typem pola
        public void SetValue(int value)
        {
            //pypisujemy wartość parametru do wartości pola
            //w związku ze zbieżnością nazw pola i parametru musimy odwołać się do klasy poprzez "this"
            this.value = value;

            Console.WriteLine($"value otrzymało nową wartość: {value}");
        }

        //Auto-property
        //property posiada zintegrowany getter i setter
        //property pozwala na modyfikowanie poziomu dostępu do gettera i setter
        public string Description { get; /*private*/ set; }


        //backfiled dla property
        private int quantity;
        //full-property
        public int Quantity
        {
            //gettera wbudowanego w proerty
            get
            {
                return quantity;
            }
            //setter wbudowany w property posiada niejawny parametr o nazwie value
            set
            {
                quantity = value;
                Console.WriteLine($"Quantity zmieniło wartość na {value}");
            }
        }





        public void DoSth()
        {
            InroduceSelf();
        }


        //<modyfikator dostępu> <typ zwracany> <nazwa metody>() - public / internal / private / protected
        //private boluje dostęp spoza klasy
        private void InroduceSelf()
        {
            Console.WriteLine(GetType().FullName);
        }
    }
}