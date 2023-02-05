using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Programming.Concepts.Collections
{
    public class CollectionsDemo
    {
        public void TestCollections()
        {
            //Console.WriteLine("Testing Collections Method.");
            ArrayList list = new ArrayList();
            //list.Add("chaitanya");
            //list.Add("narendra");
            //list.Add("dasari");
            //list.Add("31");


            string choice = "N";
            do
            {
                Console.WriteLine("Enter ur item:");
                string item = Console.ReadLine();
                list.Add(item);
                Console.WriteLine("Do u want to continue");
                choice = Console.ReadLine();


            } while (choice == "Y" || choice == "y");




                Console.WriteLine("number of items:" + list.Count);
            for(int i=0,x=1;i<list.Count;i++,x++)
            {
                Console.WriteLine( x + ". value in the list:" +list[i]);

            }


        }
    }
}
