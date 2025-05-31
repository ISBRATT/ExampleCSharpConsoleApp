// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name? ");
var name = Console.ReadLine();
Console.WriteLine($"Hello, {name}");

Console.WriteLine("Please give me a number:");
var number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please give me another number:");
var number2 = int.Parse(Console.ReadLine());
Console.WriteLine("We will now add these numbers");
var addition = number1 + number2;
Console.WriteLine(addition);
