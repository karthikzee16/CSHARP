string name = Console.ReadLine();

switch (name.ToUpper())
{
    case "TIM" or "TIMOTHY":
        Console.WriteLine("Welcome Proffesor");
        break;

    default:
        Console.WriteLine("Welcome Student");
        break;
}


name = name.ToUpper();
if (name.Equals("TIM") || name.Equals("TIMOTHY")) 
{
    Console.WriteLine("Welcome Proffesor");
}
else
{
    Console.WriteLine("Welcome Student");
}



Console.ReadLine();
