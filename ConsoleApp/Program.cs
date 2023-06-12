

//deklaracja zmiennej lokalnej o typie string (ciąg znaków) i nazwie helloVariable
string helloVariable;
//nie możemy używać zmiennej, która nie została zainicjalizowana

//inicjalizacja zmiennej - pierwsze przypisanie wartości (może być wartością null)
helloVariable = "Hello";

//instrukcje kończymy znakiem średnika
Console.WriteLine(helloVariable);

//deklaracja z inicjalizacją
string worldString = "world";
Console.WriteLine(worldString);

//przypisanie wartości
worldString = "World";


string helloOuput;

//łączenie stringów za pomocą +
helloOuput = helloVariable + " " + worldString + "!";
Console.WriteLine(helloOuput);

//łączenie stringów za pomocą funkcji Concat (pparametry wypisane po przecinku)
helloOuput = string.Concat(helloVariable, " ", worldString, "!");
Console.WriteLine(helloOuput);

//łączenie stringów za pomocą funkcji format, gdzie przekazujemy jak ma wyglądać string i z jakich elementów ma się składać ( {0} - index paramtru, liczony od 0 )

//helloOuput = string.Format("{0} {1}!", helloVariable, worldString);
string helloFormat = "{0} {1}!";
helloOuput = string.Format(helloFormat, helloVariable, worldString);
Console.WriteLine(helloOuput);

helloOuput = string.Format(helloFormat, "Ala", "ma kota");
Console.WriteLine(helloOuput);

//łączenie stringów z wykorzystaniem interpolacji (string interpolation)
helloOuput = $"{helloVariable} {worldString}!";
Console.WriteLine(helloOuput);

//łączenie stringów za pomocą funkcji Join (pierwszy parametr to separator)
helloOuput = string.Join(" -^- ", helloVariable, worldString, "ala", "makota");
Console.WriteLine(helloOuput);