using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ostatni_raz;

namespace ostatni_raz
{
    public class Employee
    {
        public List<Employee> employees = new List<Employee>();
        public int maxResult = -1;
        Employee employeeWithMaxResult = null;
        

        public List<int> score = new List<int>();
        public string name;
        public string surname;
        public int age;
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
}