using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Utils
{
  public class RandomNumberManager
    {

        public int GetNumber(int min,int max)
        {
            Random ran= new Random();
            int num=ran.Next(min, max);
            return num;


        }

    }
}
