using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private int salary;

        public Employee(int id , string firstName , string lastName , int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public int getID()
        {
            return id;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getName()
        {
            return firstName + lastName;
        }
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int Salary)
        {
            salary = Salary;
        }
        public int getAnnualSalary()
        {
            return salary * 12;
        }
        public int RaiseSalary(int Percent)
        {
            return ((salary * Percent)/100) + salary;
        }
        public override string ToString()
        {
            return String.Format("Employee[id={0},name = firstName lastName,salary{1}]");
            //return base.ToString();
        }
    }
}
