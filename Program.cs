using System;
using System.Reflection;

namespace PracticalWork2
{
    public class Calculator
    {
 
        public int Add(int a, int b)
        {
            return a + b;
        }

        private double Dev(int a, int b)
        {
            if (b == 0) return 0;
            return (double)a / b;
        }

        public double ShowDivision(int a, int b)
        {
            return Dev(a, b);
        }

        public long Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
    }

    public class User
    {
        public string Username = "";
        public int Age;
        public string Email = "";

        public void PrintInfo()
        {
            Console.WriteLine($"Пользователь: {Username}, Возраст: {Age}, Email: {Email}");
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var addMethod = typeof(Calculator).GetMethod("Add");
            int sum = (int)addMethod.Invoke(calc, new object[] { num1, num2 });
            Console.WriteLine($"Результат сложения: {sum}");
            Console.WriteLine($"Результат деления 10 / 2: {calc.ShowDivision(10, 2)}");

            User user1 = new User();
            user1.Username = "Anastasia";
            user1.Age = 18;
            user1.Email = "anastasia@mail.ru";
            user1.PrintInfo();


            Console.Write("Введите число для факториала: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал {number}: {calc.Factorial(number)}");

        }
    }
}





