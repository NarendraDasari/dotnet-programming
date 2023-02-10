using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Chaitanya.Models;

namespace Com.Chaitanya.Programming.Concepts.Collections
    
{
    public class CollectionsDemo
    {
        public void TestCollections()
        {
            //Console.WriteLine("Testing Collections Method.");
            ArrayList list = new ArrayList();

            // system automatically does boxing to convert value types to object types while assigning into ArrayList
            list.Add("chaitanya");
            list.Add("narendra");
            list.Add("dasari");
            list.Add(31);




            Person per = new Person();
            per.FirstName = "aaaaaa";
            per.LastName = "bbbbbb";
            per.DateOfBirth = "03/2/2000";
            list.Add(per);


            Console.WriteLine("String name of Person class:" + per.ToString());


            //string choice = "N";
            //do
            //{
            //    Console.WriteLine("Enter ur item:");
            //    string item = Console.ReadLine();
            //    list.Add(item);
            //    Console.WriteLine("Do u want to continue");
            //    choice = Console.ReadLine();


            //} while (choice == "Y" || choice == "y");


            
            


                Console.WriteLine("number of items:" + list.Count);
            for(int i=0,x=1;i<list.Count;i++,x++)
            {
                
                if(list[i].ToString() == "Com.Chaitanya.Models.Person")
                {
                    // explicit type casting is required here, as system cannot implicitly covert object  to Person type.
                    Person obj = (Person)list[i];
                    Console.WriteLine(x + ". value in the list:" + obj.FirstName);
                    Console.WriteLine(x + ".value in the list:" + obj.LastName);
                    Console.WriteLine(x + ".value in the list:" + obj.DateOfBirth);

                }
                else
                {
                    // system automatically un-box the object types to value types
                    Console.WriteLine(x + ". value in the list:" + list[i]);
                }
                

            }


        }
    }
}
