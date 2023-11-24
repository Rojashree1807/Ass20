using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            do { 
                Console.Write("Enter the task number (1-8): ");
                int task = int.Parse(Console.ReadLine());
                
                switch (task)
                {
                    case 1:
                        Console.WriteLine("Hello, World!");
                        break;
                    case 2:
                        Console.Write("Please enter your name: ");
                        string userName = Console.ReadLine();
                        Console.WriteLine($"Hello, {userName}!");
                        break;
                    case 3:
                        Console.WriteLine("enter the first number: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the second number: ");
                        int num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"adding {num1} and {num2}={num1 + num2}");

                        Console.WriteLine($"subtracting {num1} and {num2}={num1 - num2}");

                        Console.WriteLine($"multiplying {num1} and {num2}={num1 * num2}");

                        if (num2 != 0)
                        {
                            Console.WriteLine($"dividing {num1} and {num2}={num1 / (double)num2}");
                        }
                        else
                        {
                            Console.WriteLine("cannot divided by zero");
                        }

                        Console.WriteLine($"modulus: {num1 % num2}");
                        break;
                    case 4:
                   
                            Console.Write("Enter an integer: ");
                            int Number = int.Parse(Console.ReadLine());
                            if (Number % 2 == 0)                        
                                Console.WriteLine("The number is even.");
                            else                           
                                Console.WriteLine("The number is odd.");                           
                                break;
                    case 5:
                        Console.WriteLine("Numbers from 1 to 10:");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write($"{i} \n");
                        }                    
                        break;
                    case 6:
                        int[] intArray = { 12,16,18,5,7 };
                        int sum = 0;
                        foreach (var num in intArray)
                        {
                            sum += num;
                        }
                        double average = (double)sum / intArray.Length;
                        Console.WriteLine($"Sum of array elements: {sum}");
                        Console.WriteLine($"Average of array elements: {average}");
                            break;
                    case 7:
                        Console.Write("Enter an integer to calculate its factorial: ");
                        if (int.TryParse(Console.ReadLine(), out int factorialInput))
                        {
                            int CalculateFactorial(int n)
                            {
                                if (n == 0)
                                    return 1;
                                else
                                    return n * CalculateFactorial(n - 1);
                            }
                            int result = CalculateFactorial(factorialInput);
                            Console.WriteLine($"Factorial: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for factorial calculation.");
                        }
                        break;
                    case 8:
                        int age;
                        bool validAge = false;
                    
                        do
                        {
                            Console.Write("Enter your age: ");
                            if (int.TryParse(Console.ReadLine(), out age))
                            {
                                validAge = true;
                                if(age <18)
                                    Console.WriteLine("You are a minor.");
                               else if(age >= 18 && age <= 6)
                                    Console.WriteLine("You are an adult.");
                                    else if (age > 65)                                
                                        Console.WriteLine("You are a senior."); 
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for age. Please enter a valid integer.");
                            }
                        } while (!validAge);              
                        break;
                    default:
                        Console.WriteLine("Enter the valid task number");
                        break;
                    }
                Console.WriteLine("do you wanna continue? (yes/no): ");
                userChoice = Console.ReadLine().ToLower();

            }
            while (userChoice == "yes");

            Console.ReadKey();
        }
    }
}
