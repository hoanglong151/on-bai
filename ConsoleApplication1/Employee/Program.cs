using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(2,"Hoang","Long",2000);
            Console.WriteLine("The Employee has ID of " + e1.getID() + " FirstName of " + e1.getFirstName() + " and LastName of " + e1.getLastName() + " and Salary of " + e1.getSalary());
            Employee e2 = new Employee(12, "Hoang", "Long", 3000);
            Console.WriteLine("The Employee has ID of {0} , Name : {1} , Salary : {2} , AnnualSalary : {3} and RaiseSalary : {4} " ,e2.getID() , e2.getName() , e2.getSalary() , e2.getAnnualSalary() , e2.RaiseSalary(100));
        }
    }
}
