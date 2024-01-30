namespace BeginnerCalc
{
    class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.Write("Enter first number: ");
        calculator.number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        calculator.number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Addition: {0}", calculator.Addition());
        Console.WriteLine("Substract: {0}", calculator.Subtract());
        Console.WriteLine("Multiply: {0}", calculator.Multiply());
        Console.WriteLine("Divide: {0}", calculator.Divide());

        //Console.ReadKey();
    }
}
}