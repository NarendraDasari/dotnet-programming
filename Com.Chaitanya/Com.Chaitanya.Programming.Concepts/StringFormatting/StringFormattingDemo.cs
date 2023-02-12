using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Programming.Concepts.StringFormatting
{
    public class StringFormattingDemo
    {
        public void TestingStringFormat()
        {
            string name = "ssssss";
            string honor = "awesome";
            string honor2 = "rock";
            string deal = "phone";


            Console.WriteLine("Hello {0}, Welcome. You are {1}. You {2}. You won a {3} today.", name, honor, honor2, deal);
            Console.WriteLine("hello" + name + ", Welcome." + "You are " + honor + "." + "you " + honor2 +"." + "You won a " + deal + "today.");


            string msg = "hello " + name + ",Welcome.";


            msg = msg + "Your email is good.";

            msg +=  "something";
            //string msg1 = 

            





            Console.WriteLine(msg);



            StringBuilder builder = new StringBuilder();
            builder.Append("Hello ");
            builder.Append(name);
            builder.Append(",Welcome.");
            builder.Append("You are ");
            builder.Append(honor);
            builder.Append(".");
            builder.Append("you ");
            builder.Append(honor2);
            builder.AppendLine(".");
            builder.Append("You won a ");
            builder.Append(deal);
            builder.Append(" today.");


            Console.WriteLine("Message using string builder is:" + builder.ToString());

        }
    }
}
