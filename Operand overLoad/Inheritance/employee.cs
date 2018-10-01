using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        public int Id { get; set; }
        
        public static bool operator== (Employee person1, Employee person2)
        {
            bool same = false;
            if (person1.Id == person2.Id)
            {
                same = true;
            }
            return (same);
        }
        
        public static bool operator!=(Employee person1, Employee person2)
        {
            bool same = true;
            if(person1.Id == person2.Id)
            {
                same = false;
            }
            return (same);
        }
    }
}
