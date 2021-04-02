using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Person //user define class not free define. 
    {
        public string firstName; //this are called field,propertys,instance variable etc.
        public string middleName;
        public string lastName;

        public string getFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
