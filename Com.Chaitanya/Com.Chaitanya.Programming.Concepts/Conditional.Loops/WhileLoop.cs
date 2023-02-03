using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Com.Chaitanya.Utils;

namespace Com.Chaitanya.Programming.Concepts.Conditional.Loops
{
    public class WhileLoop
    {

        public void RollTheDice()
        {
            Console.WriteLine("Do you want to roll the dice? (Y/N):");
            string choice = Console.ReadLine();
            while(choice=="Y" || choice=="y")
            {
                //   get a random number within the range b/w 0 and 7

                RandomNumberManager man = new RandomNumberManager();
                int number=man.GetNumber(1,7);
                Console.WriteLine("Your number is:" + number);

                Console.WriteLine("Do you want to continue?(Y/N)");
                choice=Console.ReadLine();


            }
        }

    }
}
