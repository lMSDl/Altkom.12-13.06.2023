
Console.WriteLine("Podaj string:");
string inputString = Console.ReadLine();
var splitedInput = inputString.Split(" ");


for (int index = 0; index < splitedInput.Length; index++)
{
    string element = splitedInput[index];
    Console.WriteLine(element);
}

//foreach zwaraca po kolei eszystkie elementy wskazanej kolekcji
foreach(string element in splitedInput)
{
    Console.WriteLine(element);
}




void For()
{
    //I - inicjalizacja pętli - wykonuje się tylko raz na początku
    //II - warunek kontynuacji pętli - wykonuje się przed każdym wykonaniem ciała
    //III - ciało funkcji
    //IV - akcja po wykonaniu ciała pętli - najcześciej inkrementacja licznika

    //for(I;II;IV)
    //{
    //  III
    //}

    for (int i = 0; i < 5; i++ /*i = i + 1*/)
    {

        Console.WriteLine(i);

    }

    Console.WriteLine();

    int value = 3;
    //pomijamy etap I
    for (; value < 5; value++)
    {

        Console.WriteLine(value);

    }

    value = 3;
    //pomijamy etap I i IV
    for (; value < 5;)
    {

        Console.WriteLine(value);

        value = value + 1;
    }

    value = 3;
    //coś na kształt while(true)
    for (; ; )
    {
        if (value > 10 && value < 15)
        {
            value++;
            continue;
        }
        else if (value < 20)
        {
            Console.WriteLine(value);
            value++;
        }
        else
        {
            break;
        }
    }


    Console.WriteLine("Podaj string:");
    string inputString = Console.ReadLine();
    var splitedInput = inputString.Split(" ");

    for (int index = 0; index < splitedInput.Length; index++)
    {
        Console.WriteLine(splitedInput[index]);
    }
}


void WhileDoWhile()
{

    Console.WriteLine("Początek pętli while(true)");
    //pętla nieskończona
    while (true)
    {
        string input = Console.ReadLine();

        if (input == "exit")
        {
            //przerwanie pętli
            break;
        }

        Console.WriteLine(input);
    }
    Console.WriteLine("Koniec pętli while(true)");


    Console.WriteLine("Początek pętli while(!exit)");
    bool exit = false;
    //pętle while sprawdza warunek przed wejściem do ciała (jest możliwość, że pętla nigdy się nie wykona)
    while (!exit)
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "exit":
                exit = true;
                //break nie przerywa pętli, ponieważ dotyczy on switch'a
                break;
            default:
                Console.WriteLine(input);
                break;
        }
    }

    Console.WriteLine("Koniec pętli while(!exit)");



    Console.WriteLine("Początek pętli do-while");
    //do-while sprawdza warunek po wykonaniu ciałą - zawsze wykona się przynajmniej raz
    exit = false;
    do
    {
        string input = Console.ReadLine();
        if (input == "break")
        {
            //przerwanie wykonywania ciała pętli i całej pętli
            break;
        }
        else if (input == "continue")
        {
            //przerwanie wykonywania ciała, ale nie przerywamy pętli (rozpoczynamy kolejną iterację)
            continue;
        }

        if (input == "exit")
        {
            exit = true;
        }
        else
        {
            Console.WriteLine(input);
        }

    } while (!exit);
    Console.WriteLine("Koniec pętli do-while");


    Console.WriteLine("Podaj string:");
    string inputString = Console.ReadLine();
    var splitedInput = inputString.Split(" ");

    int index = 0;
    while (index < splitedInput.Length)
    {
        Console.WriteLine(splitedInput[index]);
        index = index + 1;
    }
}



void ArraysAndLists()
{
    string a = "ala";
    string b = "ma";
    string c = "kota";


    //tworzymy tablicę z 3 wskazanych elementów
    string[] stringArray = { a, b, c };
    Console.WriteLine($"Rozmiar tablicy: {stringArray.Length}");

    //tworzymy pustą tablicę 3 elementową dla stringów
    string[] anotherStringArray = new string[3];
    Console.WriteLine($"Rozmiar tablicy: {anotherStringArray.Length}");
    //przypisujemy wartości pod konkretne indeksy tablicy (indeks liczony od 0)
    anotherStringArray[0] = a;
    anotherStringArray[1] = b;
    anotherStringArray[2] = c;
    //max indeks = Length-1
    Console.WriteLine(anotherStringArray[0] + anotherStringArray[1] + anotherStringArray[2]);
    Console.WriteLine(string.Format("{0} {1} {2}", stringArray));

    //odwrócenie kolejności elementów w tablicy
    Array.Reverse(stringArray);
    Console.WriteLine($"{stringArray[0]} {stringArray[1]} {stringArray[2]}");

    //tworząc tablicę zostaje ona wypełniona wartościami domyślnymi (dla string -> null, dla int/long/float/double... -> 0)
    int[] intArray = new int[3];
    //przekształcamy tablicę do listy
    List<int> intListFromintArray = intArray.ToList();

    //List jest klasą generyczną, czyli potrzebuje określenie typu elementów na których będzie pracować (typ podaje się w <>)
    List<int> intList = new List<int>();
    //nowa lista jest pusta i dodając noew elementy zwiększamy jej rozmiar
    intList.Add(1);
    intList.Add(4);
    intList.Add(6);
    intList.Add(12);
    intList.Add(553);

    //możemy utworzyć wstępnie wypełnioną listę
    List<string> stringList = new List<string>() { a, b, c };

    //usuwając elemnt z listy, zmniejsza ona swój rozmiar
    //Remove usuwa konkretną wartość
    intList.Remove(553);
    //RemoveAt usuwa wartość spod podanego indeksu
    intList.RemoveAt(2);

    stringList.Add("!");

    //do elementów listy możemy odwoływać się jak do elementów tablicy - przez indekser
    Console.WriteLine(stringList[0] + stringList[1] + stringList[2]);

    //w celu użycia listy w string.Format należyt przekształcić ją na tablicę
    Console.WriteLine(string.Format("{0} {1} {2}", stringList.ToArray()));

    Console.WriteLine();

    string input = Console.ReadLine();
    //metoda Split dzieli string wg podanego separatora (w tym przypadku spacja) i zwraca tablicę stringów
    string[] splitedInput = input.Split(" ");

    Console.WriteLine($"Pierwszy element: {splitedInput[0]}");
    Console.WriteLine($"Ostatni element: {splitedInput[splitedInput.Length - 1]}");

    Console.WriteLine();
}




void InputValidation()
{
    string inputString = Console.ReadLine();

    int inputInt;
    bool canParse = int.TryParse(inputString, out inputInt);

    if (!canParse)
    {
        Console.WriteLine($"Nie można przekształcić {inputString} na int");
    }
    else
    {
        Console.WriteLine($"Wprowadzona wartość: {inputInt}");
    }
}



void Switch()
{
    string inputString = Console.ReadLine();
    int inputInt = int.Parse(inputString);

    if (inputInt > 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest więszka od 0");
    }
    else if (inputInt < 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest mniejsza od 0");
    }
    else
    {
        Console.WriteLine($"Wartość {inputInt} jest równa 0");
    }


    //switch przyjmuje parametr, który porównywany jest z listą przypadów (case'ów)
    switch (inputInt)
    {
        case > 0:
            Console.WriteLine($"Wartość {inputInt} jest więszka od 0");
            break;

        case < 0:
            Console.WriteLine($"Wartość {inputInt} jest mniejsza od 0");
            break;

        //default jest opcjonalny i wywołuje się gdy nie znaleziono odpowiedniego case
        default:
            Console.WriteLine($"Wartość {inputInt} jest równa 0");
            break;
    }


    Console.WriteLine("Jak masz na imię?");
    string name = Console.ReadLine();
    switch (name)
    {
        case "":
            Console.WriteLine("Szkoda, że nie chcesz podać swojego imienia");
            break;
        case "Alexa":
            Console.WriteLine("Hej, masz na imię tak jak asystem Amazon?");
            break;
        default:
            Console.WriteLine($"Cześć {name}, jak się czujesz?");
            break;
    }

}



void If()
{

    string inputString = Console.ReadLine();
    int inputInt = int.Parse(inputString);

    //porównanie wartości - podwójny znak ==
    bool result = inputInt == 0;
    Console.WriteLine(result);

    if (result)
    {
        Console.WriteLine($"Wartość {inputInt} jest równa 0");
    }

    //różne - !=   
    if (inputInt != 0)
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
    if (inputInt > 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest więszka od 0");
    }
    else if (inputInt < 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest mniejsza od 0");
    }
    //else bez if = wykonaj jeśli znie znalazłeś wcześniej dopasowania
    else //if (inputInt == 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest równa 0");
    }




    Console.WriteLine("-----");

    if (inputInt >= 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest więszka lub równa 0");
    }

    // || - logiczne lub
    if (inputInt > 0 || inputInt == 0)
    {
        Console.WriteLine($"Wartość {inputInt} jest więszka lub równa 0");
    }
    // && - logiczne and
    if (inputInt > 0 && inputInt <= 10)
    {
        Console.WriteLine($"Wartość {inputInt} jest z przedziału (0;10>");
    }

    if (inputInt > 0 && (inputInt < 10 || inputInt == 10))
    {
        Console.WriteLine($"Wartość {inputInt} jest z przedziału (0;10>");
    }
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