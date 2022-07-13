// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// this program calculate the area of a rectangle

Console.WriteLine("Please write the base");
float rectangeBase = float.Parse(Console.ReadLine());
Console.WriteLine("Please write the height");
float height = float.Parse(Console.ReadLine());

float area = rectangeBase * height;
Console.WriteLine("The rectangle's area is: " + area);