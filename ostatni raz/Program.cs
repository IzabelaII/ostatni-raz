﻿using ostatni_raz;

var employee = new Employee("Adam","Nowak");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

//Console.WriteLine("Average:" + statistics.Average);
//Console.WriteLine("Min:" + statistics.Min);
//Console.WriteLine("Max:" + statistics.Max);

SetSth(out statistics);
void SetSth (out Statistics statistics) 
{
    statistics = new Statistics();
}
