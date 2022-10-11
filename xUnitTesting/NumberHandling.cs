using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting
{
    public class NumberHandling
    {

        //Addition  
        public int Addition(int[] input)
        {

            int result = input[0];
            for (int i = 0; i < input.Length; i++) {
                result = result + input[i];
            }
            return result;
        }

        //Substraction  
        public int Subtraction(int[] input)
        {
            // Input at array 0 otherwise the input is negative instead of whats being subtracted
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = result - input[i];
            }
            return result;
        }
        //Multiplication  
        public int Multiplication(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = result * input[i];
            }
            return result;
        }
        public int Multiplication(int myIntOne, int myIntTwo)
        {
           return myIntOne * myIntTwo;
        }

        //Division  
        public int Division(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = result / input[i];
            }
            return result;
        }

        public int Division(int myIntOne, int myIntTwo)
        {
            return myIntOne / myIntTwo;
        }

        // Overloaded Addition
        public int Addition(int myIntOne, int myIntTwo)
        {                 
            return myIntOne + myIntTwo;
        }



        //Overloaded Subtraction

        public int Subtraction(int myIntOne, int myIntTwo)
        {

            return myIntOne - myIntTwo;
        }
    }
}
