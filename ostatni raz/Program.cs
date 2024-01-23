

 public class Employee
    {
        public List<Employee> employees = new List<Employee>();
        public int maxResult = -1;
        Employee employeeWithMaxResult = null;
        

        private List<int> score = new List<int>();
        private string name;
        private string surname;
        private int age;
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public Employee(string name, string surname, int age)
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


List<Employee> employees = new List<Employee>() { employee1, employee2, employee3 };
int maxResult = -1;
int result = 0;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
        
}




Console.WriteLine("Najlepszym pracownikiem jest"  +  employeeWithMaxResult  +  "z wynikiem" +  maxResult);