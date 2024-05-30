bool isComplete = true;
//always use curly braces when using if-else (more readable)
if (isComplete)
{
    Console.WriteLine("The statement is true");
}
else 
{ 
    Console.WriteLine("The statement is false");
}

string? firstName = Console.ReadLine();
string lastName = string.Empty;

if (firstName.ToUpper() == "TIM")
{
    Console.WriteLine("Hello Mr.Corey");
    lastName = "Corey";
}
else 
{
    Console.WriteLine($"Hello {firstName}");
    lastName = "Smith";
}


Console.WriteLine(lastName);
Console.ReadLine();

