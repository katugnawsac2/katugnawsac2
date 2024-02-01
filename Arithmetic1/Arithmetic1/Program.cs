using System;

namespace Arithmetic
{

    public class Math
    {
        public int Add(int num1, int num2)
        { return num1 + num2; }
        public int Sub(int num1, int num2)
        { return num1 - num2; }
        public int Multiply(int num1, int num2)
        { return num1 * num2; }
        public int Divide(int num1, int num2)
        { return num1 / num2; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Math math = new Math();

            int num1, num2;
            //ADDITION
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total sum of two numbers is:" + math.Add(num1, num2));

            //SUBTRACTION
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total subtract of two numbers is:" + math.Sub(num1, num2));
            //MULTIPLICATION
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total multiply of two numbers is:" + math.Multiply(num1, num2));

            //DIVISION
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total divide of two numbers is:" + math.Divide(num1, num2));




        }



    }







}
