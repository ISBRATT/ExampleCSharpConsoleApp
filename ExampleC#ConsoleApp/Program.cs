// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("What is your First name? ");
var name = Console.ReadLine();
Console.WriteLine("What is your Surname? ");
var surname = Console.ReadLine();   
Console.WriteLine($"Hello, {name} {surname}");

Console.WriteLine("We are now going to multply two numbers:");
Console.WriteLine("Please give me a number:");

var number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please give me another number:");
var number2 = int.Parse(Console.ReadLine());
Console.WriteLine("We will now multiply these numbers");
var addition = number1 * number2;
Console.WriteLine(addition);
