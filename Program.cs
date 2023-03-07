// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


DateTime hireDate = new DateTime();
Console.WriteLine(hireDate);

int age = 43;

bool b = age >= 12;

Console.WriteLine("What do you want to do?");
Console.WriteLine("1: Nothing");
Console.WriteLine("2: Something");
string input = Console.ReadLine();

switch (input) {
    case "1":
        Console.WriteLine("That is fine.");
        break;
    case "2":
        Console.WriteLine("That is great.");
        break;
    default:
        Console.WriteLine("Great");
        break;
}