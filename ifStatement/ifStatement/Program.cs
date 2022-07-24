float[] giveNumbers()
{
    float[] numbers;
    Console.WriteLine("Give the first number");
    float num1 = (float)Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Give the second number");
    float num2 = (float)Convert.ToDouble(Console.ReadLine());

    numbers = new float[] { num1, num2 };
    return numbers;
}

float sum(float a, float b) => a + b;

float rest(float a, float b) => a - b;

float multiplicate(float a, float b) => a * b;

float divide(float a, float b) => a / b;

Console.WriteLine("MENU \n" +
    "please make sure to choose the correct number referring to what you want to do\n" +
    "1 to sum\n" +
    "2 to rest\n" +
    "3 to multiplicate\n" +
    "4 to divide");

try
{
    int option = Convert.ToInt32(Console.ReadLine());
    if (option == 1)
    {
        Console.WriteLine("Ok, we're gonna sum");
        float[] numbers = giveNumbers();
        float num1 = numbers[0];
        float num2 = numbers[1];
        var result = sum(num1, num2);
        Console.WriteLine($"The result is: {result}");

    }
    else if (option == 2)
    {
        Console.WriteLine("Ok, we're gonna rest");
        float[] numbers = giveNumbers();
        float num1 = numbers[0];
        float num2 = numbers[1];
        var result = rest(num1, num2);
        Console.WriteLine($"The result is: {result}");

    }
    else if (option == 3)
    {
        Console.WriteLine("Ok, we're gonna multiplicate");
        float[] numbers = giveNumbers();
        float num1 = numbers[0];
        float num2 = numbers[1];
        var result = multiplicate(num1, num2);
        Console.WriteLine($"The result is: {result}");

    }
    else if (option == 4)
    {
        Console.WriteLine("Ok, we're gonna divide");
        float[] numbers = giveNumbers();
        float num1 = numbers[0];
        float num2 = numbers[1];
        var result = divide(num1, num2);
        Console.WriteLine($"The result is: {result}");
    }
    else
    {
        Console.WriteLine("Please type a correct option :)");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




