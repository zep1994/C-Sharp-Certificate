// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//DateTime hireDate = new DateTime();
//Console.WriteLine(hireDate);

//int age = 43;

//bool b = age >= 12;
static void Menu()
{
    Console.WriteLine("Welcome! \nSelect your choice!");

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1: Nothing");
    Console.WriteLine("2: Something");
    Console.WriteLine("99: Close Application");
}
Menu();
int input = int.Parse(Console.ReadLine());


while (input != 99)
{
    switch (input)
    {
        case 1:
            Console.WriteLine("That is fine.");
            break;
        case 2:
            Console.WriteLine("That is great.");
            break;
        default:
            Console.WriteLine("Great");
            break;
    }
    Menu();
    if ((input != 1) || (input != 2) || (input != 99)) {
        input = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Exiting Application.");
