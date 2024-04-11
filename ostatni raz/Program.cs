int number = 4594;
string numberAsString = number.ToString();
char[] chars = numberAsString.ToCharArray();
List<char> namberOfNambers = new List<char>(10);
int number0 = 0;
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;
int number6 = 0;
int number7 = 0;
int number8 = 0;
int number9 = 0;

foreach (char leter in chars) 
{
    if (leter == '0')
    {
        number0++;
    }
    else if (leter == '1') 
    {
        number1++;
    }
    else if (leter == '2')
    {
        number2++;
    }
    else if (leter == '3')
    {
        number3++;
    }
    else if (leter == '4')
    {
        number4++;
    }
    else if (leter == '5')
    {
        number5++;
    }
    else if (leter == '6')
    {
        number6++;
    }
    else if (leter == '7')
    {
        number7++;
    }
    else if (leter == '8')
    {
        number8++;
    }
    else if (leter == '9')
    {
        number9++;
    }
}


 
Console.WriteLine("Wyniki dla numeru:4594");
Console.WriteLine($"0=> {number0}");
Console.WriteLine($"1=> {number1}");
Console.WriteLine($"2=> {number2}");
Console.WriteLine($"3=> {number3}");
Console.WriteLine($"4=> {number4}");
Console.WriteLine($"5=> {number5}");
Console.WriteLine($"6=> {number6}");
Console.WriteLine($"7=> {number7}");
Console.WriteLine($"8=> {number8}");
Console.WriteLine($"9=> {number9}");

