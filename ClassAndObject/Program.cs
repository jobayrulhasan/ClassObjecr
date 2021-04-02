using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person(); //call by user
            per.firstName = "Md.";
            per.middleName = "Rofiq";
            per.lastName = "Udding";
            Person per1 = new Person(); //Here per1 is representing person class object. this is called instance
            per1.firstName = "Mohammad";
            per1.middleName = "Sharif";
            per1.lastName = "Uddin";
            Person per2 = new Person();
            per2.firstName = "Shakib";
            per2.middleName = "Al";
            per2.lastName = "Hasan";
            string fullname = per.getFullName();
            string fullname1 = per1.getFullName();
            string fullname2 = per2.getFullName();
            Console.WriteLine("His name is : {0}",fullname);
            Console.WriteLine("His name is : {0}",fullname1);
            Console.WriteLine("His name is : {0}",fullname2);
            Console.ReadKey();
        }
    }
}
