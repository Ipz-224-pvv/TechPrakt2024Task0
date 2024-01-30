try
{
    Console.Write("Enter first number: ");
    var number1 = decimal.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    var number2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Sum of two numbers ({0};{1}) equals {2}", number1, number2, number1 + number2);
}
catch
{
    Console.WriteLine("There was occured some error");
}
