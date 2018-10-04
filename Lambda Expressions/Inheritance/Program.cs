using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(String[] args)
        {
            Employee<int> Employee1 = new Employee<int>() { FirstName = "Joe", LastName = "Shmoe" , Id = 1};
            Employee<int> Employee2 = new Employee<int>() { FirstName = "Alex", LastName="Murphy",Id = 2 };
            Employee<int> Employee3 = new Employee<int>() { FirstName = "Mike", LastName = "Burger", Id = 3 };
            Employee<int> Employee4 = new Employee<int>() { FirstName = "Porcini", LastName = "Mushroom", Id = 4 };
            Employee<int> Employee5 = new Employee<int>() { FirstName = "Alotta", LastName = "Salami", Id = 5 };
            Employee<int> Employee6 = new Employee<int>() { FirstName = "Jen", LastName = "Quick", Id = 6 };
            Employee<int> Employee7 = new Employee<int>() { FirstName = "Ben", LastName = "Sutherland", Id = 7 };
            Employee<int> Employee8 = new Employee<int>() { FirstName = "Nathan", LastName = "Heurich", Id = 8 };
            Employee<int> Employee9 = new Employee<int>() { FirstName = "Constance", LastName = "Bellingham", Id = 9 };
            Employee<int> Employee10 = new Employee<int>() { FirstName = "Joe", LastName = "Rogaine", Id = 10 };

            List<Employee<int>> employees = new List<Employee<int>>()
            {
                Employee1,
                Employee2,
                Employee3,
                Employee4,
                Employee5,
                Employee6,
                Employee7,
                Employee8,
                Employee9,
                Employee10
            };
            List<string> firstNames = new List<string>();
            foreach (Employee<int> employee in employees)
            {
                
                if (employee.FirstName == "Joe")
                {
                    firstNames.Add(employee.FirstName);
                }
            }

            foreach (string firstName in firstNames)
            {
                Console.WriteLine(firstName);
            }

            List<Employee<int>> joesListLambda = new List<Employee<int>>();
            joesListLambda = employees.Where(x=>x.FirstName == "Joe").ToList();
            foreach (Employee<int> employee in joesListLambda)
            {
                Console.Write(employee.FirstName);
                Console.Write(employee.LastName);
            }

            List<Employee<int>> firstNamesLambda = new List<Employee<int>>();
            firstNamesLambda = employees.FindAll(x => x.Id > 5);

            foreach (Employee<int> employee in firstNamesLambda)
            {
                Console.WriteLine(employee.FirstName);
            }
            

            Console.Read();
        }
    }
}
