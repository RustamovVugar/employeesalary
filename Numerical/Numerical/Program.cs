using Numerical.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerical
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Name = "Mustafa", Age = 20, Salary = 2500 });
            employees.Add(new Employee { Name = "Eli", Age = 35, Salary = 1300 });
            employees.Add(new Employee { Name = "Melek", Age = 17, Salary = 450 });
            employees.Add(new Employee { Name = "HTML", Age = 38, Salary = 1200 });
            employees.Add(new Employee { Name = "C++", Age = 19, Salary = 5500 });


            double avg = employees.Average(m => m.Salary);
            var result = employees.FindAll(m => m.Age > 20 && m.Age < 40 && m.Salary > avg).ToList();
            int sum = 0;
            int count = 0;

            foreach (var employees in result)
            {
                sum += employees;
                count++;
            }
            

            



            
            
        }

    }
}

