
Employee employee1 = new Employee("Ada", "Gruszka", 33);
employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(3);
employee1.AddScore(3);

Employee employee2 = new Employee("Monika", "Jabłko", 25);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(3);

Employee employee3 = new Employee("Zuza", "Śliwka", 18);
employee3.AddScore(3);
employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(6);
employee3.AddScore(4);



public class Employee
{
    List<string> employee = new List<string>();

    public string name;
    public string surname;
    public int age;
    public Employee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }

    List<int> score = new List<int>();
    public void AddScore(int number)
    {
        this.score.Add(number);

    }

    List<int> result = new List<int>();
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
   public int maxResult = -1;
   public Employee employeeWithMaxResult = null;

}

foreach (var employee in Employee)
{
    
}