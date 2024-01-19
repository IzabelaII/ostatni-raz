using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ostatni_raz
{
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
        public Employee( string name, string surname, int age)
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



foreach (int Employee Result in Employees Results)
{
    if (Employee Result > employeeWithMaxResult)
     {
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine($"Najwyższą oceną pracownika" employeeWithMaxResult "z wielością"maxResult);
