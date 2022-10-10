using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTesting;

namespace CalculatorApp
{
    class Calculator
    {

        
        static void Main(string[] args)
        {
            NumberHandling numberHandling = new NumberHandling();


            string action = "";
            while (action.ToLower() != "exit")
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division \n");                
                Console.WriteLine("Type exit to End Program");
                action = Console.ReadLine();
                string input_1 = "0";      

                if (action.ToLower() != "exit")
                {
                    Console.Write("Ange dina tal, separerade med mellanslag: ");
                    input_1 = Console.ReadLine();
                }

                string[] inputArray = input_1.Split(' ');


                int[] myInts =  Array.ConvertAll(input_1.Split(' '), int.Parse);




                int result = 0;
                switch (action.ToLower())
                {
                    case "1":
                        if (myInts.Length > 2)
                        {
                            result = numberHandling.Addition(myInts);
                        }
                        else if (myInts.Length == 2 )
                        {                           
                            result = numberHandling.Addition(myInts[0], myInts[1]);
                        }
                        
                            break;
                        
                    case "2":
                        if (myInts.Length > 2)
                        {
                            result = numberHandling.Subtraction(myInts);
                        }
                        else if (myInts.Length == 2)
                        {
                            result = numberHandling.Subtraction(myInts[0], myInts[1]);
                        }

                        break;
                    case "3":                        
                            result = numberHandling.Multiplication(myInts);
                            break;                        
                    case "4":                       
                            result = numberHandling.Division(myInts);
                            break;

                }
                if(action.ToLower() != "exit")
                {
                    Console.WriteLine("The result is {0}", result);
                }
               
            }          
        }
    }
}

