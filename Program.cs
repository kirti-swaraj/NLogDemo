using System;

namespace NLogDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number for addtion");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number for addtion");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            AddNumber addNumbers = new AddNumber();
            Console.WriteLine("Addition of " + firstNumber + "and" + secondNumber + "is" + addNumbers.Add(firstNumber, secondNumber));
        }
    }
}
