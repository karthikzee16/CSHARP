Dictionary<int, string> lookup = new Dictionary<int, string>();

lookup[1] = "a";
lookup[2] = "b";
lookup[3] = "c";
lookup[4] = "d";

Console.Write("Enter an id:");


bool isId = int.TryParse(Console.ReadLine(), out int Id); 

if (isId)
{
    Console.WriteLine($"The employee with id of {Id} is {lookup[Id]}");
}

Console.ReadLine();
