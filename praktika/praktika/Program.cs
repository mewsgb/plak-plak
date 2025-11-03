using System;

class Program
{
    static void Main()
    {
      

        while (true)
        {
            try
            {
                Console.Write("\nВведите первое число: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Выберите операцию (+, -, *, /): ");
                string op = Console.ReadLine();

                double result = op switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" when b != 0 => a / b,
                    "/" when b == 0 => throw new DivideByZeroException(),
                    _ => throw new Exception("Неизвестная операция!")
                };

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите числа правильно!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: На ноль делить нельзя!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}