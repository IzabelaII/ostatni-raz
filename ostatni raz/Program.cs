

using ostatni_raz;

Employee employee1 = new Employee("Adam", "Gruszka", 18);
Employee employee2 = new Employee("Zuza", "Jabłko", 32);
Employee employee3 = new Employee("Damian", "Wiśnia", 28);

employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);

employee2.AddScore(6);
employee2.AddScore(3);
employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(9);

employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(7);


List<Employee> employees = new List<Employee>();
List<int> score = new List<int>();
var maxResult = -1;
Employee employeeWithMaxResult = null;



foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z największą ilością punktów to:" );
Console.WriteLine(maxResult);
