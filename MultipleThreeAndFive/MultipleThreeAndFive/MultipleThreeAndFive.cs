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
            if(num < 0)
            {
                throw new NegativeInputException("Negative input provided, expected positive input!");
            }

            if (num % 3 == 0 || num % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }

    /**
     * ClassName: NegativeInputException
     * 
     * Thrown when a negative input is provided where positive inupt is expected
     */
    public class NegativeInputException : Exception
    {
        /**
         * Constructor
         */
        public NegativeInputException() : base(){}

        /**
         * Constructor
         * 
         * @param message, the error message 
         */
        public NegativeInputException(string message) : base(message){}

    }
}
