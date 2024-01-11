using System;
using System.Net.NetworkInformation;

string name = "Ewa";
bool isWoman = true;
int age = 30;

if (isWoman == true && age <= 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else _ = (age > 30 || !isWoman);
{
    Console.WriteLine("NIC");
}
