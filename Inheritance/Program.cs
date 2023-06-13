

using Inheritance.Models;

//polimorfizm - możliwość przedstawienia jendej klasy nako inny typ (w zaklresie hierarchi dziedziczenia)
List<Shape> shapes = new List<Shape>();

Shape1D shape1D = new Point();

shapes.Add(shape1D);

//Console.WriteLine(shape1D.Name);

shape1D = new Square(3);
//przedstawiając obiekt jako klasę nadrzętną mamy dostęp tylko do tego co oferuje ten typ nadrzęny
//w tym przypadku nie mamy dostepu do wysokości
//shape1D.Height = 5;

shapes.Add(shape1D);
shapes.Add(new Line(10));

Shape2D shape2d = new Rectangle(2, 6);
shape2d.Height = 5;

shapes.Add(shape2d);


foreach (var item in shapes)
{
    Console.WriteLine(  item.ToString() );
}

IName name = new Rectangle(2, 3);
name.GetName();