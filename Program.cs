using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIntegerExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter second number: ");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Please enter action: ");
            char action = char.Parse(Console.ReadLine());

            BigInteger integer = new BigInteger(firstNumber, secondNumber);
            string result = "" ;
            switch (action)
            {
                case '+': result = integer.Addition();break;
                case '-': result =  integer.Substraction();  break;
                case '*': result = integer.Myultiplication(); ; break;
                case '/': result = integer.Division(); break; 
                default:
                    Console.WriteLine("You are idiot");
                    break;
            }

            Console.WriteLine(result);

            Console.ReadKey(true);
        }
    }
}
