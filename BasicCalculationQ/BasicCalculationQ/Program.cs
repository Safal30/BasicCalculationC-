using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculationQ
{
    class Program
    {
        static void Main(string[] args) // this is a method called Main
        {
            Start:
            Random randomInteger = new Random(); // declaring random a a class
           
            int num1 = randomInteger.Next(1,101);
            int num2 = randomInteger.Next(1,50);
            int additionSwitch = randomInteger.Next(1, 4);

            int finalAnswer;
            int first;
            int second;
            int third;
            int fourth;

            Console.WriteLine("1 = Addition , 2 = Subtrction , 3 = Multiplication , 4 = Division");
            Console.WriteLine("Please choose which type of question you want to answer?");
            int answer = Convert.ToInt32(Console.ReadLine()); // reads the user input and converts it to an integer

            if (answer == 1)
            {
                Console.WriteLine(num1 +  " + " + num2);
                finalAnswer = Convert.ToInt32(Console.ReadLine()); 

                if (finalAnswer == num1 + num2)
                    switch (additionSwitch) // creates additional else ifs statements
                    {
                        case 1:
                            Console.WriteLine("You are correct!");
                            break;
                        case 2:
                            Console.WriteLine(finalAnswer + " is right!");
                            break;
                        default:
                            Console.WriteLine("Right Answer!!");
                            break;
                    }
                else
                {
                    int difference = Math.Abs(finalAnswer - (num1 + num2)); /* difference class is set to 
                    absolute value of finalAnswer - (num1 + num2) //// Math.Abs = Math Absolute Answer */
                    if (difference == 1)
                    {
                        Console.WriteLine("So close!!");
                    }
                    else if (difference <= 10)
                    {
                        Console.WriteLine("Quite close but not there!");
                    }
                    else
                        Console.WriteLine("Nowhere near close! Please try again!");
                    
                }
                    

            }
            else if (answer == 2)
            {
                Console.WriteLine(num1  + " - " + num2);
                finalAnswer = Convert.ToInt32(Console.ReadLine());
                if (finalAnswer == num1 - num2)
                    Console.WriteLine("You are correct!");
                else
                    Console.WriteLine("You are wrong");

            }
            else if (answer == 3)
            {
                Console.WriteLine(num1 + " * " + num2);
                finalAnswer = Convert.ToInt32(Console.ReadLine());
                if (finalAnswer == num1 * num2)
                    Console.WriteLine("You are correct");
                else
                    Console.WriteLine("You are wrong");
            }
            else if (answer == 4)
            {
                Console.WriteLine(num1 + " / " + num2);
                finalAnswer = Convert.ToInt32(Console.ReadLine());
                if (finalAnswer == num1 / num2)
                    Console.WriteLine("You are correct!");
                else
                    Console.WriteLine("You are wrong!");
            }
            Console.ReadLine();

            goto Start;
        }
    }
}
