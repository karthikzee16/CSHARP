
using static System.Runtime.InteropServices.JavaScript.JSType;



char[][] letters = new char[2][3];


static int Factorial(int number)
{
    int result = 1;
    //your code goes here
    if (number <= 1) return 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;


    }
    return result;
}

int result = Factorial(5);





int a = 1, b = 2, c = 3;

Console.WriteLine("First is: " + a + ", second is: " + b + ", Third is: " + c);
Console.WriteLine(
    $"First is: {a}, second is: {b} , third is {c}");

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
Compute(firstNumber, secondNumber, operation);


Console.WriteLine("Press any key to close");
Console.ReadKey();


static void Compute(int firstNumber, int secondNumber, string operation) 
{

    if (IsCaseInsensetive(operation,"A"))
    {
        Console.WriteLine("" + firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber));
    }

    else if (IsCaseInsensetive(operation, "S"))
    {

        Console.WriteLine("" + firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber));
    }

    else if (IsCaseInsensetive(operation, "M"))
    {
        Console.WriteLine("" + firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber));

    }

    else
    {
        Console.WriteLine("Invalid Option");
    }

    return;


}

static bool IsCaseInsensetive (string left , string right) 
{
    return left.ToUpper() == right.ToUpper();
}
