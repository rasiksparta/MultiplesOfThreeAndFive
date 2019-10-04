using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleThreeAndFive
{
    public class MultipleThreeAndFive
    {
        public MultipleThreeAndFive() { }

        /**
         * Checks if a given non negative integer is a multiple of three or five
         * 
         * @param num, the input integer
         * @return true, positive check
         */
        public bool IsMultipleOfThreeOrFive(int num)
        {
            if (num < 0)
            {
                throw new NegativeInputException("Negative input provided, expected positive input!");
            }

            if (num % 3 == 0 || num % 5 == 0)
            {
                return true;
            }
            return false;
        }

        /**
         * 
         */
        public List<int> EvaulateNumbersInRange(int boundA, int boundB)
        {
            List<int> list = new List<int>();

            for (int num = boundA; num <= boundB; num++)
            {
                if (IsMultipleOfThreeOrFive(num))
                {
                    list.Add(num);
                }
            }

            return list;
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
        public NegativeInputException() : base() { }

        /**
         * Constructor
         * 
         * @param message, the error message 
         */
        public NegativeInputException(string message) : base(message) { }
    }

    public class InvalidBoundException : Exception
    {
        public int LowerBound { get; }
        public int UpperBound { get; }
 
        /**
         * Constructor
         */
        public InvalidBoundException() : base() { }

        /**
         * Constructor
         * 
         * @param message
         */
        public InvalidBoundException(string message) : base(message) { } 

        /**
         * Constructor
         * 
         * @param message
         * @param lowerBound
         * @param upperBound
         */
        public InvalidBoundException(string message, int lowerBound, int upperBound) :base(message)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
        }
    }
}
