using Com.Chaitanya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            p2.DateOfBirth = "2/4/2001";



            plist.Add(p1);
            plist.Add(p2);


          
               
            //p.Add







        }
        
    }
}
