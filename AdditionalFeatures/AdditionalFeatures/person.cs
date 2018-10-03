using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    public class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public person(string FName) : this(FName, "")
        {

        }
        public person(string FName, string LName)
        {
            firstName = FName;
            lastName = LName;
        }
        
    }
}
