using System;
using MyLibrary;  // подключаем нашу DLL

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.PrintHello();// тестируем , правда я не понимаю че здесь вообще тестировать ну и ладно
            Console.WriteLine($"5 + 3 = {calc.Add(5, 3)}");
            Console.WriteLine($"4.5 * 2 = {calc.Multiply(4.5, 2)}");
            Console.WriteLine(calc.о("User"));   
        }
    }
}
