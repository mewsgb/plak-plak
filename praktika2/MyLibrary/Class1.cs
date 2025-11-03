namespace MyLibrary
{
    public class Calculator
    {
        public void PrintHello()// без возвращаемого
        {
            Console.WriteLine("Hello world!");
        }
        public int Add(int a, int b)//  с возвращаемым
        {
            return a + b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public string о(string name)
        {
            return $"Hello, {name}!";
        }

    }

}
