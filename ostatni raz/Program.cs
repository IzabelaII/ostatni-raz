var name = "Adam";
var age = 15;
var isMan = true;

if (!isMan && age < 30)
{
    Console.WriteLine("Kobieta po niżej 30 lat.");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa , lat 30");
}
else if (isMan && age < 18)
{
    Console.WriteLine("Niepenoletni męszczyzna");
}
else
{
    Console.WriteLine("NIC");
}