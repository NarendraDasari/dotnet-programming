using Com.Chaitanya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Com.Chaitanya.Programming.Concepts.Generic.Collections
{
    /// <summary>
    /// 
    /// </summary>
    public class ListDemo
    {
        /// <summary>
        /// 
        /// </summary>
        public void TestingList()
        {

            // List<data-type> obj-name = new List<data-type>();
            List<string> st = new List<string>();
            st.Add("chaitu");
            st.Add("nanduri");


            List<int> ints=new List<int>();
            ints.Add(42);
            ints.Add(23);


            List<Person> plist = new List<Person>();
            Person p1 = new Person();
            p1.FirstName = "sssss";
            p1.LastName = "aaaaaa";
            p1.DateOfBirth = "3/2/2000";
            
            Person p2= new Person();
            p2.FirstName = "qqqqqq";
            p2.LastName = "wwwwww";
            p2.DateOfBirth = "03/4/2001";




            plist.Add(p1);
            plist.Add(p2);


            

            for (int i= 0;i< st.Count;i++)
            {
                Console.WriteLine(st[i]);
            }
            for(int x=0;x<ints.Count;x++)
            {
                Console.WriteLine(ints[x]);
            }
          

            //p.Add

            printPersonList(plist);
            //// conuts the  person list
           
            //Console.WriteLine("number of items inPerson list:" + plist.Count);
            ////clear the person list and counts it.
            //plist.Clear();
            //Console.WriteLine("number of items inPerson list:" + plist.Count);




            ////removes a person object at specific index

            // plist.RemoveAt(0);
            // printPersonList(plist);




            ////Removes a person object if u don't know the index.
            // plist.Remove(p2);
            // printPersonList(plist);



            List<Person> newplist=new List<Person>();
            Person p3 = new Person();
            p3.FirstName = "chaitu";
            p3.LastName = "nanduri";
            p3.DateOfBirth = "6/26/1987";
            newplist.Add(p3);

            Person p4 = new Person();
            p4.FirstName = "narendra";
            p4.LastName = "dasari";
            p4.DateOfBirth = "5/30/1982";
            newplist.Add(p4);

            printPersonList(newplist);

            Console.WriteLine("count of new person list" + newplist.Count);
            Console.WriteLine("counts of person list before add range:" + plist.Count);



            plist.AddRange(newplist);
            Console.WriteLine("person list count after add range:" + plist.Count);

            printPersonList(plist);


        }
        private void printPersonList(List<Person> peoples)
        {
            
            for (int y = 0; y < peoples.Count; y++)
            {
                Person per = peoples[y];
                Console.WriteLine("Firstname :" + per.FirstName);
                Console.WriteLine("Lastname:" + per.LastName);
                Console.WriteLine("Date of birth" + per.DateOfBirth);
                Console.WriteLine("age " + per.Age);
            }

        }
        
    }
}
