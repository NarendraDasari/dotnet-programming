using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Com.Chaitanya.Models;

namespace Com.Chaitanya.Programming.Concepts.Arrays
{
    public class SimpleArraysDemo
    {
        public void ForLoopProgram()
        {

            Console.WriteLine("How many persons do u want:");


            string size=Console.ReadLine();

            try {
                int count = Convert.ToInt32(size);
                Person[] people = new Person[count];

                for (int i = 0; i < people.Length; i++)
                {
                    Console.WriteLine("Enter firstname:");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Enter lastname:");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("Enter person DOB:");
                    string dob = Console.ReadLine();
                   // Console.WriteLine("Enter age:");
                    //string age = Console.ReadLine();

                    Person p = new Person();
                    p.firstname = firstname;
                    p.lastname = lastname;
                    p.dob = dob;
                    //p.age = Convert.ToInt32(age);

                    people[i] = p;


                }

                printPersons(people);
            }
            catch (Exception ex) {
                //  capture this stacktrays and message from the exceotion object and log this details to our log file.
                // show a user friendly message on the console.
                Console.WriteLine("OOPS something went wrong .please close the program and try again.");
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
            
            
          

        }


        private void printPersons(Person[] people)
        {
            for (int x = 0; x < people.Length; x++)
            {
                Console.WriteLine("Person firstname:" + people[x].firstname);
                Console.WriteLine("Person lastname" + people[x].lastname);
                Console.WriteLine("Person DOB:" + people[x].dob);
                Console.WriteLine("Person age:" + people[x].GetAge());
            }
        }

    }
}
