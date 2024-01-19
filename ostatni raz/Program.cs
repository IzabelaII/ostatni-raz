

using ostatni_raz;

Employee employee1 = new Employee("Ada", "1975", "Ada", "Gruszka", 33);
Employee employee2 = new Employee("Monika", "1975", "Monika", "Jabłko", 25);
Employee employee3 = new Employee("Zuza", "1975", "Zuza", "Śliwka", 18);


employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(3);
employee1.AddScore(3);

employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(3);

employee3.AddScore(3);
employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(6);
employee3.AddScore(4);
var result = employee2.Result;
Console.WriteLine(result);
Console.WriteLine();
class Employee
{
    public List<Employee> employees = new List<Employee>();
    public int maxResult = -1;
    Employee employeeWithMaxResult = null;
   
 
 
    private List<int> score = new List<int>();
    private string name;
    private string surname;
    private int age;
    public class Employees(string login, string password, string name, string surname, int age, int score);
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public Employee(string login, string pasword, string name, string surname, int age)
    {
        this.score = score;
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
       
    }

   

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }

    public void AddScore(int number)
    {
        this.score.Add(number);

    }
}



foreach (employee in Employees)
{
    if (Employee  Result > maxResult)
     {
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine($"Najwyższą oceną pracownika" employeeWithMaxResult "z wielością" maxResult);
