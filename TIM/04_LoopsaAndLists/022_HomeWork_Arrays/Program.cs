string[] names = {"Tim","Bob","Frank" };

Console.WriteLine("Select a number");

bool isNumber = int.TryParse(Console.ReadLine(), out int numberInput);

if (isNumber) 
{
    if (numberInput == 0) 
    {
        Console.WriteLine("Numbers start from 1");
    }
    else if (numberInput > names.Length)
    {
        Console.WriteLine("Selected Number is out of range");
    }

    else 
    {
        Console.WriteLine($"The name at position number {numberInput} is {names[numberInput-1]}");
    }

}

else
{
    Console.WriteLine("Plese enter numbers only");
}


Console.ReadLine();

