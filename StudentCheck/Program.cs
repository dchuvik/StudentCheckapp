




Console.Write("What is your name: ");
string firstName = Console.ReadLine();

Console.Write("What is your age: ");
bool isValidInt = int.TryParse(Console.ReadLine(), out int age);

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    Console.WriteLine("Hello Professor");
}
else
{
    Console.WriteLine("I don't know who you are.");
    if (age < 21)
    {
        Console.WriteLine($"you are recommended to wait {21 - age} years," +
            $" until you are 21, to start this class");
    }
    else
    {
        Console.WriteLine("welcome to class");
    }

}


