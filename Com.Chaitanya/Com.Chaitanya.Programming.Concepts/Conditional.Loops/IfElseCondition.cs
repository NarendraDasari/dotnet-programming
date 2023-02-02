using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Programming.Concepts.Conditional.Loops
{
    public class IfElseCondition
    {

        public void TestIfelseCondition()
        {
            Console.WriteLine("Executing IfElse Condition.");
            Console.WriteLine("Enter ur firstname:");
            


           string firstname= Console.ReadLine();

            Console.WriteLine("Enter lastname");

            string lastname = Console.ReadLine();

            Console.WriteLine("Enter Middlename");
            string middlename = Console.ReadLine();

            if(lastname=="")
            {
                greetUser(firstname);
            }
            else if(middlename=="")
            {
                greetUser(firstname, lastname);
            }
            else
            {
                greetUser(firstname, middlename, lastname);
            }
            

        }
        private void greetUser(string firstname)
        {
            Console.WriteLine("Welcome ," + firstname);
            
        }

        private void greetUser(string firstname,string lastname)
        {
            Console.WriteLine("Welcome ," + firstname +" " + lastname);
        }

        private void greetUser(string firstname,string middlename,string lastname)
        {
            Console.WriteLine("Welcome ," + firstname + " " + middlename + " " + lastname);
        }


    }
}
