
string inputString = Console.ReadLine();
int inputInt = int.Parse(inputString);

//porównanie wartości - podwójny znak ==
bool result = inputInt == 0;
Console.WriteLine(result);

if(result)
{
    Console.WriteLine($"Wartość {inputInt} jest równa 0");
}

//różne - !=   
if(inputInt != 0)
{
    Console.WriteLine($"Wartość {inputInt} jest różna od 0");
}

//negacja - !
if (!(inputInt == 0))
{
    Console.WriteLine($"Wartość {inputInt} jest różna od 0");
}

Console.WriteLine("-----");

//else łączy if'y, przez co w takim bloku może wykonać się tylko jeda akcja opowiadająca warunkowi
if(inputInt > 0)
{
    Console.WriteLine($"Wartość {inputInt} jest więszka od 0");
}
else if(inputInt < 0)
{
    Console.WriteLine($"Wartość {inputInt} jest mniejsza od 0");
}
//else bez if = wykonaj jeśli znie znalazłeś wcześniej dopasowania
else if (inputInt >= 0)
{
    Console.WriteLine($"Wartość {inputInt} jest równa 0");
}




Console.WriteLine("-----");

if(inputInt >= 0)
{
    Console.WriteLine($"Wartość {inputInt} jest więszka lub równa 0");
}

// || - logiczne lub
if (inputInt > 0 || inputInt == 0)
{
    Console.WriteLine($"Wartość {inputInt} jest więszka lub równa 0");
}
// && - logiczne and
if(inputInt > 0 && inputInt <= 10 )
{
    Console.WriteLine($"Wartość {inputInt} jest z przedziału (0;10>");
}

if (inputInt > 0 && (inputInt < 10 || inputInt == 10))
{
    Console.WriteLine($"Wartość {inputInt} jest z przedziału (0;10>");
}




void Numbers()
{
    /*TimeSpan t = TimeSpan.FromSeconds(119345);

    string answer = string.Format("{4}d.{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                    t.Hours,
                    t.Minutes,
                    t.Seconds,
                    t.Milliseconds,
                    t.Days);
    Console.WriteLine(answer);*/

    int a = 11;
    int b = 4;


    int c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
    c = a % b;
    Console.WriteLine($"{a} % {b} = {c}");

    c = a + a * a;
    Console.WriteLine($"{a} + {a} * {a} = {c}");
    c = (a + a) * a;
    Console.WriteLine($"({a} + {a}) * {a} = {c}");

    //Łączenie liczb i stringów
    /*Console.WriteLine(1 + 2 + "3");
    Console.WriteLine("1" + (2 + 3));
    Console.WriteLine("1" + "2" + "3");*/


    float aa = 11f;
    float bb = 4.0f;

    float cc = aa + bb;
    Console.WriteLine($"{aa} + {bb} = {cc}");
    cc = aa - bb;
    Console.WriteLine($"{aa} - {bb} = {cc}");
    cc = aa * bb;
    Console.WriteLine($"{aa} * {bb} = {cc}");
    cc = aa / bb;
    Console.WriteLine($"{aa} / {bb} = {cc}");



    Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
    Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
    Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");


    Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
    Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
    Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

    //operacje int i float/double/decimal (albo odwrotnie) daje wynik o typie z wyższą precyzją
    Console.WriteLine(5 / 34f); //f - float
    Console.WriteLine(5 / 34d); //d - double
    Console.WriteLine(5 / 34m); //m - decimal


    long longValue = 10000000000000;
    //rzutowanie potrzebne gdy chcemy zapisać wartość o typie z wikeszą precyzją do typu o mniejszej precyzji
    int intValue = (int)longValue;
    Console.WriteLine(intValue);
    intValue = int.MaxValue;
    longValue = intValue;
    Console.WriteLine(longValue);


    float floatVal = int.MaxValue;
    Console.WriteLine(floatVal);

    floatVal = (float)545.2312;
    Console.WriteLine(floatVal);


    //parsowanie/konwertowanie string na int
    string value = Console.ReadLine();
    int parsedValue = int.Parse(value);
    int result = parsedValue + 2;

    Console.WriteLine(result);

    //parsowanie/konwertowanie string na float
    value = Console.ReadLine();
    float parsedFloat = float.Parse(value);

    Console.WriteLine($"{parsedFloat} * 2 = {parsedFloat * 2}");
}


//Funkcja o nazwie Strings, nie przyjmująca parametrów i nie zwracająca wyniku (void)
void Strings()
{
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


    Console.WriteLine($"string \"{helloOuput}\" ma długość {helloOuput.Length}");

    string output = $"string \"{helloOuput}\" ma długość {helloOuput.Length}";
    Console.WriteLine(output.ToUpper());
    Console.WriteLine(output);

    output = output.Replace(" -^- ", ", ").Substring(5, 10);
    Console.WriteLine(output);


    string input = Console.ReadLine();
    Console.WriteLine(input.ToLower());
}