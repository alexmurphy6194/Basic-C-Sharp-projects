using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string cantTouchThis = "Try me";
            Console.WriteLine(cantTouchThis);
            var newPerson = new person("alex");
            var newPerson2 = new person("bob", "murphy");

            Console.Read();
        }
    }
}
