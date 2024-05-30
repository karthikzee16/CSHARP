Console.WriteLine("What is your first name:");
string firstName = Console.ReadLine();


Console.WriteLine("What is your last name:");
string lastName = Console.ReadLine();

if (firstName.ToUpper() == "TIM" &&
    lastName.ToUpper() == "COREY")
{
    Console.WriteLine("Hello Mr. Corey");
}
else if (firstName.ToUpper() == "TIM")
{
    Console.WriteLine("Hello , you have a cool first name");
}
else
{
    Console.WriteLine("Sorry you don't have a cool name");
}

    