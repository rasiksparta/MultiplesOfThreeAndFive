using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleThreeAndFive
{
    public class MultipleThreeAndFive
    {
        public MultipleThreeAndFive(){}

        /**
         * Checks if a given non negative integer is a multiple of three or five
         * 
         * @param num, the input integer
         * @return true, positive check
         */
        public bool IsMultipleOfThreeOrFive(int num)
        {
            if (num % 3 == 0 || num % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
