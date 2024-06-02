Console.WriteLine("please enter your name and age");
Console.Write("Name:");
string name = Console.ReadLine();

Console.Write("Age:");
int age = int.Parse(Console.ReadLine());

if (name.ToUpper() == "BOB" || name.ToUpper() == "SUE") 
{
    name = "Proffessor" + name;
    Console.WriteLine("Hello Professor!");
}

if (age < 21) 
{
    Console.WriteLine($"Please wait {21-age} years before starting this class");
}

else
{
    Console.WriteLine($"Hi {name} , you can start this class!");
}

Console.ReadLine();
