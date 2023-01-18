using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World...!");
            // Console.ReadKey(); this make sure you program Stop for a while till you observe the result.
           
            //playing with variables
            int firstNumber = 10;
            int secondNumber = 12;

            int totalAmount = firstNumber + secondNumber;
            Console.WriteLine(totalAmount);

            //geting inputs from user
            Console.WriteLine("Enter your Name:");
            string myName =  Console.ReadLine();
            Console.WriteLine("name is - "+ myName);

            //converting types
            Console.WriteLine("Enter your input(number):");
            string whatEverUserInput = Console.ReadLine();
            int convertToInteger = Convert.ToInt32(whatEverUserInput);
            Console.WriteLine("Wntered Number is : "+ convertToInteger);

            /* making
             * simple
             * calculator
             * using
             * Swich cases
             */
            Console.WriteLine("Calculator using Switch cases :");
            Console.WriteLine("type number 1");
            string getNumber = Console.ReadLine();
            int number1 = Convert.ToInt32(getNumber);

            Console.WriteLine("type number 2");
            string getNumber2 = Console.ReadLine();
            int number2 = Convert.ToInt32(getNumber2);

            Console.WriteLine("add operator:");
            string opratorCal = Console.ReadLine();

            switch(opratorCal)
            {
                case "+":
                    Console.WriteLine(number2+ number1);
                    break;

                case "-":
                    Console.WriteLine(number2 - number1);
                    break;
                case "*":
                    Console.WriteLine(number2*number1);
                    break;
                case "/":
                    Console.WriteLine(number2 / number1);
                    break;

            }
            /*
             * 
             * end of Calculator
             * 
             */
        }
    }
}
