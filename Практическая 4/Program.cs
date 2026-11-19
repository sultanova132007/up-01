using System;

namespace ConsoleApp_Tema4_try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int y = int.Parse(Console.ReadLine());

                int result = x / y;
                Console.WriteLine($"Результат: {result}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");

            Console.WriteLine();

            int x2 = 0;
            int y2 = 0;

            try
            {
                Console.Write("Введите первое число для проверки фильтра: ");
                x2 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число для проверки фильтра: ");
                y2 = int.Parse(Console.ReadLine());

                int result1 = x2 / y2;
                int result2 = y2 / x2;
                Console.WriteLine($"Результат: {result1}");
            }
            catch (DivideByZeroException) when (y2 == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

           
            int[] numbers = { 10, 20, 30, 40 };

            try
            {
                Console.Write("Введите индекс элемента массива (от 0 до 3): ");
                int index = int.Parse(Console.ReadLine());

                int value = numbers[index];
                Console.WriteLine($"Значение по индексу {index}: {value}");

                int x = 5;
                int y = x / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}