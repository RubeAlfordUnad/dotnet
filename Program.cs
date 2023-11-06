// See https://aka.ms/new-console-template for more information
using Humanizer;


Console.WriteLine("Please insert a name");
var name = Console.ReadLine();
Console.WriteLine("Please insert your charge");
var charge = Console.ReadLine();
Console.WriteLine("Please insert your age");
var age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hi, My name is {name}, my charge is {charge} and I´m {age.ToWords()} years old");
