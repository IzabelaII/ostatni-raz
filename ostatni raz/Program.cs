
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;

///Przygotuj program, który policzy ile jakich cyfr występuje w podanej liczbie:
///
///Przykład:
///Wyniki dla liczb: 4566
///0=>0
///1=>0
///2=>0
///3=>0
///4=>1
///5=>1
///6=>2
///7=>0
///8=>0
///9=>0
int number = 4566;
string numberAsString = number.ToString("4566");
char[] letters = numberAsString.ToArray('4', '5', '6', '6');

Console.WriteLine("podaj liczbe:");
int couter0 = 0; ;
int couter1 = 0;
int couter2 = 0;
int couter3 = 0;
int couter4 = 0;
int couter5 = 0;
int couter6 = 0;
int couter7 = 0;
int couter8 = 0;
int couter9 = 0;
foreach (char letter in letters)
{
    if (letter == 0)
    {
        Console.WriteLine(couter0++);
    }
    else if (letter == 1)
    {
        Console.WriteLine(couter1++);
    }
    else if (letter == 2)

    {
        Console.WriteLine(couter2++);
    }
    else if (letter == 3)
    {
        Console.WriteLine(couter3++);
    }
    else if (letter == 4)
    {
        Console.WriteLine(couter4++);
    }
    else if (letter == 5)
    {
        Console.WriteLine(couter5++);
    }
    else if (letter == 6)
    {
        Console.WriteLine(couter6++);
    }
    else if (letter == 7)
    {
        Console.WriteLine(couter7++);
    }
    else if (letter == 8)
    {
        Console.WriteLine(couter8++);
    }
    else if (letter == 9)
    {
        Console.WriteLine(couter9++);
    }
}