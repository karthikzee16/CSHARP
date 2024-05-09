
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string  firstString= Console.ReadLine();
int firstNumber  = int.Parse(firstString);

//Console.WriteLine("First Number:"+firstNumber);
Console.WriteLine("Input the second number:");

string secondString = Console.ReadLine();
int secondNumber = int.Parse(secondString);

//Console.WriteLine("Second Number:" + secondNumber);

Console.WriteLine();

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A] dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string operation = Console.ReadLine();

if (operation == "A" || operation == "a")
{
    Console.WriteLine("" + firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber));
}

else if (operation == "S" || operation == "s")
{
    Console.WriteLine("" + firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber));
}

else if (operation == "M" || operation == "m")
{
    Console.WriteLine("" + firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber));

}

else 
{
    Console.WriteLine("Invalid Option");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();
