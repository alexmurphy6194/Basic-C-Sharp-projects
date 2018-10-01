using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "bob", lastName = "murphy" };
            employee.sayName();
            Console.Read();

            IQuittable one = new Employee();
            one.Quit();


        }
    }
}
